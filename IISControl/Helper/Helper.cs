using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISControl.Helper
{
    public class Helper
    {
        public static string ObtenerValor(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static string[] GetPathDesktop()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ObtenerValor("directoryName")).Split(',');
        }
    }
}
