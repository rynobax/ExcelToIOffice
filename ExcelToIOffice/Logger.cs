using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToIOffice
{
    class Logger
    {
        private static Logger loggerInstance;
        public Logger() { }

        public static Logger Instance
        {
            get
            {
                if(Instance == null)
                {
                    loggerInstance = new Logger();
                }
                return loggerInstance;
            }
        }

        public void Log(string msg)
        {
            System.IO.StreamWriter sw = System.IO.File.AppendText(System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetEntryAssembly().Location) + "Log.txt");
            try
            {
                string logLine = System.String.Format(
                    "{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
