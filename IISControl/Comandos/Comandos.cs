using IISControl.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISControl.Comandos
{
    public class Comandos
    {
        //Ruta en donde se exporta toda la configuración del IIS cuando es por backup
        //C:\Windows\System32\inetsrv\backup\NombreDelBackup
        static string _pathExe = Helper.Helper.ObtenerValor("appcmd");
        //static string _pathDeskto = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Helper.Helper.ObtenerValor("directoryName"));
        static string _pathDesktop = Helper.Helper.GetPathDesktop()[0];
        static string _pathDesktopSites = Helper.Helper.GetPathDesktop()[1];
        static string _pathDesktopApps = Helper.Helper.GetPathDesktop()[2];
        static string _pathDesktopPools = Helper.Helper.GetPathDesktop()[3];

        static Dictionary<EnumComandos, string> comandos = new Dictionary<EnumComandos, string>
        {
            { EnumComandos.Sites, $"/C {_pathExe} list site" },
            { EnumComandos.Apps,  $"/C {_pathExe} list app" },
            { EnumComandos.Pools, $"/C {_pathExe} list apppool" },
            { EnumComandos.Todo,  $"/C {_pathExe} list site" }
        };

        static Dictionary<EnumComandos, string> comandosExport = new Dictionary<EnumComandos, string>
        {
            { EnumComandos.Sites, $"/C {_pathExe} list site \"nameApp\" /config /xml > \"{_pathDesktop}\\{_pathDesktopSites}\\directory\\sites_nameFile.xml\""},
            { EnumComandos.Apps,  $"/C {_pathExe} list app \"nameApp\" /config /xml > \"{_pathDesktop}\\{_pathDesktopApps}\\directory\\apps_nameFile.xml\"" },
            { EnumComandos.Pools, $"/C {_pathExe} list apppool \"nameApp\" /config /xml > \"{_pathDesktop}\\{_pathDesktopPools}\\directory\\pools_nameFile.xml\"" },
            { EnumComandos.Todo,  $"/C {_pathExe} list site" }
        };

        static Dictionary<EnumComandos, string> comandosImport = new Dictionary<EnumComandos, string>
        {
            { EnumComandos.Sites, $"/C {_pathExe} add site /in < \"xmlFile\"" },
            { EnumComandos.Apps,  $"/C {_pathExe} add app /in < \"xmlFile\"" },
            { EnumComandos.Pools, $"/C {_pathExe} add apppool /in < \"xmlFile\"" },
            { EnumComandos.Todo,  $"/C {_pathExe} restore backup \"NombreDelBackup\"" }
        };

        public static string ObtenerComando(EnumComandos key)
        {
            return comandos[key];
        }

        public static string ObtenerComandoExport(EnumComandos key)
        {
            return comandosExport[key];
        }

        public static string ObtenerFileName(EnumComandos key)
        {
            if(key == EnumComandos.Sites)
            {
                return Path.Combine(_pathDesktop,_pathDesktopSites,"directory", "sites_nameFile.xml");
            }

            if (key == EnumComandos.Apps)
            {
                return Path.Combine(_pathDesktop, _pathDesktopApps, "directory", "apps_nameFile.xml");
            }

            if (key == EnumComandos.Pools)
            {
                return Path.Combine(_pathDesktop, _pathDesktopPools, "directory", "pools_nameFile.xml");
            }

            return "";
        }

        public static string ObtenerComandoImport(EnumComandos key)
        {
            return comandosImport[key];
        }
    }
    public enum EnumComandos
    {
        Sites,
        Apps,
        Pools,
        Todo
    }
}
