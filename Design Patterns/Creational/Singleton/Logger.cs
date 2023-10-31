using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Singleton
{
    public class Logger
    {
        private static Logger Instance = null;
        private static readonly object lockObj = new object();

        private Logger()
        {

        }

        public static Logger GetLoggerInstance
        {
            get
            {
                lock (lockObj)
                {
                    if(Instance == null)
                    {
                        Instance = new Logger();
                    }
                }
                return Instance;
            }
        }

        public string getMessage(string logtext)
        {
            return DateTime.Now +" "+ logtext;
        }
    }
}
