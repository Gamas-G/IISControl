using IISControl.Helper;
using IISControl.Models;
using IISControl.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IISControl
{
    public partial class IISControlForm : Form
    {
        public IISControlForm()
        {
            InitializeComponent();

            ValidarCrearCarpetas();
        }
        private void OpenForms<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_contenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnl_contenedor.Controls.Add(formulario);
                pnl_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void rd_exportar_CheckedChanged(object sender, EventArgs e)
        {
            OpenForms<Exportar>();
        }

        private void rd_Importar_CheckedChanged(object sender, EventArgs e)
        {
            OpenForms<lbl_statusApps>();
        }
    
        private void ValidarCrearCarpetas()
        {
            string[] _pathsDirectories = Helper.Helper.GetPathDesktop();
            if (!Directory.Exists(_pathsDirectories[0]))
            {
                Directory.CreateDirectory(_pathsDirectories[0]);
            }

            if (!Directory.Exists(_pathsDirectories[0] + "\\" + _pathsDirectories[1]))
            {
                Directory.CreateDirectory(_pathsDirectories[0] + "\\" + _pathsDirectories[1]);
            }

            if (!Directory.Exists(_pathsDirectories[0] + "\\" + _pathsDirectories[2]))
            {
                Directory.CreateDirectory(_pathsDirectories[0] + "\\" + _pathsDirectories[2]);
            }

            if (!Directory.Exists(_pathsDirectories[0] + "\\" + _pathsDirectories[3]))
            {
                Directory.CreateDirectory(_pathsDirectories[0] + "\\" + _pathsDirectories[3]);
            }
        }
    }
}
