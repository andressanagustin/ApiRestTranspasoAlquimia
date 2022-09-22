using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace TranspasoApi.LogsError
{
    public class ELog
    {
        public static void save(object obj, Exception ex)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string hora = DateTime.Now.ToString("HH:mm:ss");
            string carpeta = HttpContext.Current.Request.MapPath("~/log/");
            string path = HttpContext.Current.Request.MapPath("~/log/" + fecha + ".txt");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            StreamWriter sw = new StreamWriter(path, true);

            StackTrace stacktrace = new StackTrace();
            sw.WriteLine(obj.GetType().FullName + " " + hora);
            sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }
    }
}