using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSystems
{
    public class Logger
    {
        private String logFile = "demo_log.txt";
        private StreamWriter writer;

        private static Logger _instance;

        public static Logger _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }

        }
         

        public Logger()
        {
            try
            {

                writer = new StreamWriter(logFile, true);
            }
            catch (IOException e) { }
        }


        public void logOpenedWindow(String username, string windowName)
        {

            writer.WriteLine("Opened " + windowName + " by " + username);

        }

        public void logClosedWindow(String account)
        {

            writer.WriteLine("Closed " + windowName + " by " + username);

        }


        public void Close()
        {
            writer.Close();
        }


    }
}