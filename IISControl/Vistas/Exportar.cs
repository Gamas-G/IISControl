using IISControl.Comandos;
using IISControl.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IISControl.Vistas
{
    public partial class Exportar : Form
    {
        List<string> nameApps = new List<string>();
        List<App> appList = new List<App>();
        public Exportar()
        {
            InitializeComponent();
            gb_Accion.Enabled = false;
            gb_Accion.Enabled = false;

            btn_exportar.Enabled = false;
            btn_seleccionar.Enabled = false;
            tv_datos.CheckBoxes = true;
            lbl_mensaje.Visible = false;
        }


        private void DetectarIIS()
        {
            var salidaProceso = EjecutarProcess("/C sc query w3svc");

            Dictionary<string, string> datos = ProcesarSalida(salidaProceso);
            if (!datos["ESTADO"].Contains("4"))
            {
                gb_Accion.Enabled = false;
                gb_InfoIIS.Enabled = false;
                lbl_hostname.Text = "No se detecto el IIS favor de validar";
                return;
            }

            gb_Accion.Enabled = true;
            gb_InfoIIS.Enabled = true;
            ObtenerHostName();
        }
        private static Dictionary<string, string> ProcesarSalida(string salida)
        {
            var datos = new Dictionary<string, string>();
            int index = 0;
            // Divide el texto en líneas
            var lineas = salida.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Analiza cada línea
            foreach (var linea in lineas)
            {
                if (index > 2) break; //Rompemos ya que solo nos interesa hasta el estado
                // Busca un patrón tipo clave: valor
                var partes = linea.Split(new[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
                var value = partes[1].Trim().Split(' ')[0];
                if (partes.Length == 2)
                {
                    string clave = partes[0].Trim();
                    string valor = value;
                    datos[clave] = valor;
                }
                index++;
            }

            return datos;
        }

        private void ObtenerHostName()
        {
            lbl_hostname.Text = System.Net.Dns.GetHostName();
        }

        private string EjecutarProcess(string arguments)
        {
            StringBuilder salida = new StringBuilder();
            StringBuilder errores = new StringBuilder();
            try
            {

                Process proceso = new Process();
                proceso.StartInfo.FileName = "cmd.exe";
                proceso.StartInfo.Arguments = arguments; // Reemplaza con tu comando
                proceso.StartInfo.RedirectStandardOutput = true;
                proceso.StartInfo.RedirectStandardError = true;
                proceso.StartInfo.UseShellExecute = false;
                proceso.StartInfo.CreateNoWindow = true;

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

                // Inicia el proceso
                proceso.Start();

                // Comienza a leer asíncronamente
                proceso.BeginOutputReadLine();
                proceso.BeginErrorReadLine();

                // Espera a que termine
                proceso.WaitForExit();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en proceso");
            }
            //return salida;
            return salida.ToString();
        }

        private bool ValidarAccionSeleccionada()
        {
            return rd_sites.Checked || rd_apps.Checked || rd_pools.Checked || rd_todo.Checked;
        }

        private void ObtenerDatosIIS()
        {
            if (rd_sites.Checked)
            {
                string salidaProceso = EjecutarProcess(Comandos.Comandos.ObtenerComando(Comandos.EnumComandos.Sites));
                RenderArbol(salidaProceso);
                //MessageBox.Show(salidaProceso);
            }
            if (rd_apps.Checked)
            {
                string salidaProceso = EjecutarProcess(Comandos.Comandos.ObtenerComando(Comandos.EnumComandos.Apps));
                RenderArbol(salidaProceso);
                //MessageBox.Show(salidaProceso);
            }
            if (rd_pools.Checked)
            {
                string salidaProceso = EjecutarProcess(Comandos.Comandos.ObtenerComando(Comandos.EnumComandos.Pools));
                RenderArbol(salidaProceso);
                //MessageBox.Show(salidaProceso);
            }
            if (rd_todo.Checked)
            {
                string salidaProceso = EjecutarProcess(Comandos.Comandos.ObtenerComando(Comandos.EnumComandos.Todo));
                RenderArbol(salidaProceso);
            }
        }

        private void RenderArbol(string datos)
        {
            if (tv_datos.Nodes.Count > 0) tv_datos.Nodes.Clear();

            // Procesar la salida y agregarla al TreeView
            var lineas = ObtenerSubString(datos);
            foreach (var linea in lineas)
            {
                if (!linea.Contains("SITE") && !linea.Contains("APP") && !linea.Contains("APPPOOL")) // Filtrar líneas con información de sitios
                {
                    continue;
                }

                // Crear un nodo para cada sitio
                string[] partes = ObtenerPartes(linea, '"');
                if (partes.Length > 1)
                {
                    //appList.Add( new App { Name = partes[1], Information = partes[2] });
                    string nombreSitio = partes[1] + partes[2]; // Nombre del sitio
                    TreeNode nodo = new TreeNode(nombreSitio);
                    nodo.Tag = partes[1];
                    tv_datos.Nodes.Add(nodo);
                }
            }
        }

        private string[] ObtenerSubString(string data)
        {
            return data.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private string[] ObtenerPartes(string data, char splictCharacter)
        {
            return data.Split(new[] { splictCharacter }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void btn_detectar_Click(object sender, EventArgs e)
        {
            DetectarIIS();
        }

        private void btn_ObtenerInformacion_Click(object sender, EventArgs e)
        {
            if (!ValidarAccionSeleccionada()) return;

            ObtenerDatosIIS();

            btn_seleccionar.Enabled = true;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "Exportanto archivos";
            lbl_mensaje.Visible = false;

            ObtenerNodosSeleccionados(tv_datos.Nodes, tv_destino);

            if (!btn_exportar.Enabled) return;
        }

        private void ObtenerNodosSeleccionados(TreeNodeCollection origen, TreeView destino)
        {
            bool seleccionados = false;
            destino.Nodes.Clear(); // Limpiar el segundo TreeView antes de agregar nuevos nodos
            nameApps.Clear();

            foreach (TreeNode nodo in origen.Cast<TreeNode>().Where(n => n.Checked))
            {
                TreeNode nuevoNodo = (TreeNode)nodo.Clone(); // Clonar el nodo para no afectar el original
                destino.Nodes.Add(nuevoNodo);
                nameApps.Add(nuevoNodo.Tag.ToString());

                if (!seleccionados) seleccionados = true;
            }

            if(seleccionados) btn_exportar.Enabled = true;
            else btn_exportar.Enabled = false;
        }

        private void rd_sites_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            lbl_mensaje.Text = "Exportanto archivos";
            lbl_mensaje.Visible = false;
        }

        private void Reset()
        {
            tv_datos.Nodes.Clear();
            tv_destino.Nodes.Clear();
        }

        private void rd_apps_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            lbl_mensaje.Text = "Exportanto archivos";
            lbl_mensaje.Visible = false;
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            EnumComandos comando = EnumComandos.Sites;
            lbl_mensaje.Visible = true;

            if (rd_sites.Checked)
            {
                comando = EnumComandos.Sites;
            }
            if (rd_apps.Checked)
            {
                comando = EnumComandos.Apps;
            }
            if (rd_pools.Checked)
            {
                comando = EnumComandos.Pools;
            }
            // Expresión regular para encontrar el valor de physicalPath
            string pattern = @"physicalPath=""([^""]+)""";
            foreach (string app in nameApps)
            {
                //Remplazamos los espacios en blanco y las diagonales para tener un nombre de carpeta
                string _app = app;
                string nameFile = app.Replace("/","_");
                nameFile = nameFile.Replace(" ","_");


                //Contruimos el nombre del xmlFile
                string _xmlFile = Comandos.Comandos.ObtenerFileName(comando).Replace("nameFile", nameFile);

                //Creamos la carpeta con el nombre del site, app o pool
                string carpetaRaiz = $"{Path.GetDirectoryName(_xmlFile)}";
                string carpetaSitio = Path.GetDirectoryName(_xmlFile).Replace("directory",nameFile);
                if (!Directory.Exists(carpetaSitio))
                {
                    Directory.CreateDirectory(carpetaSitio);
                }


                string command = Comandos.Comandos.ObtenerComandoExport(comando).Replace("nameApp",_app);
                command = command.Replace("nameFile",nameFile);
                command = command.Replace("directory",nameFile);
                EjecutarProcess(command);

                _xmlFile = _xmlFile.Replace("directory", nameFile);
                using (StreamReader reader = new StreamReader(_xmlFile))
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
                                EjecutarProcess($"/C xcopy {physicalPath} {carpetaSitio}\\Archivos /E /I /Y");
                            }
                        }
                    }
                }

                lbl_mensaje.Text = "Archivos exportados, favor de validar";
            }
        }

        private void rd_pools_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            lbl_mensaje.Text = "Exportanto archivos";
            lbl_mensaje.Visible = false;
        }

        private void rd_todo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
