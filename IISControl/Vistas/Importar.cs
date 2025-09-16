using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IISControl.Vistas
{
    public partial class lbl_statusApps : Form
    {
        public lbl_statusApps()
        {
            InitializeComponent();
            txt_pathDirectory.Enabled = false;

            btn_importar.Enabled = false;
        }

        private void btn_fileDialog_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openfile = new FolderBrowserDialog())
            {
                if (openfile.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                
                btn_importar.Enabled = true;
                txt_pathDirectory.Text = openfile.SelectedPath;
            }
        }

        private async void btn_importar_Click(object sender, EventArgs e)
        {
            if (!txt_pathDirectory.Text.Contains("ExportIIS"))
            {
                MessageBox.Show("La ruta no contiene la carpeta \"ExportIIS\", favor de validar");
                btn_importar.Enabled = false;
                return;
            }
            //Primero debemos de crear la carpeta física
            string[] archivosXml = Directory.GetFiles(txt_pathDirectory.Text, "*.xml", SearchOption.AllDirectories);
            string archivos = string.Empty;

            //Arreglos de almacenamiento
            List<string> _xmlPools = new List<string>();
            List<string> _xmlSites = new List<string>();
            List<string> _xmlApps = new List<string>();

            //Guardamos los paths en sus correspondientes arreglos

            foreach (string xml in archivosXml)
            {
                //Primero los pools
                if (xml.Contains("ExportIIS\\Pools"))
                {
                    _xmlPools.Add(xml);
                }

                //Sites
                if (xml.Contains("ExportIIS\\Sites"))
                {
                    _xmlSites.Add(xml);
                }

                //Los apps son innecesarios si ya va con todo el path del site
                if (xml.Contains("ExportIIS\\Apps"))
                {
                    _xmlApps.Add(xml);
                }
            }

            //Comenzamos con un orden de aplicación
            //Primero los pools
            if(_xmlPools.Count > 0)
            {
                lbl_statusPools.Text = "Trabajando Pools";
                await Task.Run(() =>
                {
                    string comandoPool = Comandos.Comandos.ObtenerComandoImport(Comandos.EnumComandos.Pools);
                    foreach (string pool in _xmlPools)
                    {
                        string _comandoPro = comandoPool.Replace("xmlFile", pool);
                        EjecutarProcess(_comandoPro);
                        listBox_Pools.Items.Add($"Pool ejecutado => {Path.GetFileName(pool)}");
                    }
                });
            }

            if (_xmlSites.Count > 0)
            {
                lbl_statusSites.Text = "Trabajando Sites";
                //await Task.Run(() =>
                //{
                    string comandoSite = Comandos.Comandos.ObtenerComandoImport(Comandos.EnumComandos.Sites);
                    foreach (string site in _xmlSites)
                    {
                        CrearCarpetaFisica(site);
                        string _comandoPro = comandoSite.Replace("xmlFile", site);
                        EjecutarProcess(_comandoPro);
                        listBox_Sites.Items.Add($"Site ejecutado => {Path.GetFileName(site)}");
                    }
                //});
            }

            if (_xmlApps.Count > 0)
            {
                lbl_apps.Text = "Trabajando Apps";
                //await Task.Run(() =>
                //{
                    string comandoApp = Comandos.Comandos.ObtenerComandoImport(Comandos.EnumComandos.Apps);
                    foreach (string app in _xmlApps)
                    {
                        CrearCarpetaFisica(app);
                        string _comandoPro = comandoApp.Replace("xmlFile", app);
                        EjecutarProcess(_comandoPro);
                        listBox_Apps.Items.Add($"App ejecutado => {Path.GetFileName(app)}");
                    }
                //});
            }
            EjecutarProcess("/C IISRESET");

            MessageBox.Show(archivos);
        }

        private void CrearCarpetaFisica(string xmlFile)
        {
            string pattern = @"physicalPath=""([^""]+)""";
            string carpetaOrigen = Path.GetDirectoryName(xmlFile);
            using (StreamReader reader = new StreamReader(xmlFile))
            {
                string output = reader.ReadToEnd(); // Lee toda la salida de appcmd

                // Busca el physicalPath en la salida
                string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line.Contains("physicalPath"))
                    {
                        Match match = Regex.Match(line, pattern);

                        if (match.Success)
                        {
                            string physicalPath = match.Groups[1].Value; // Extrae el valor
                                                                         //MessageBox.Show($"PhysicalPath encontrado: {physicalPath}");
                            EjecutarProcess($"/C xcopy {carpetaOrigen}\\Archivos {physicalPath} /E /I /Y");
                        }
                    }
                }
            }
        }

        private string EjecutarProcess(string arguments)
        {
            StringBuilder salida = new StringBuilder();
            //StringBuilder errores = new StringBuilder();
            try
            {

                Process proceso = new Process();
                proceso.StartInfo.FileName = "cmd.exe";
                proceso.StartInfo.Arguments = arguments; // Reemplaza con tu comando
                proceso.StartInfo.RedirectStandardOutput = false;
                proceso.StartInfo.RedirectStandardError = false;
                proceso.StartInfo.UseShellExecute = true;
                proceso.StartInfo.CreateNoWindow = true;
                proceso.StartInfo.Verb = "runas";

                /*
                // Evento para manejar la salida estándar
                proceso.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        salida.Append(e.Data + "\n");
                        //Console.WriteLine($"Salida: {e.Data}");
                    }
                };

                // Evento para manejar la salida de errores
                proceso.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        errores.Append(e.Data);
                        //Console.WriteLine($"Error: {e.Data}");
                    }
                };
                */
                // Inicia el proceso
                proceso.Start();

                // Comienza a leer asíncronamente
                //proceso.BeginOutputReadLine();
                //proceso.BeginErrorReadLine();

                // Espera a que termine
                proceso.WaitForExit();


                if (proceso.ExitCode != 0)
                {
                    Console.WriteLine($"El proceso terminó con un código de error: {proceso.ExitCode}");
                }
                else
                {
                    Console.WriteLine("Proceso ejecutado correctamente.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en proceso");
            }
            //return salida;
            return salida.ToString();
        }
    }
}
