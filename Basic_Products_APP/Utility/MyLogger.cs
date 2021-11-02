using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Products_APP.Utility
{
    public class MyLogger : Ilogger
    {
        //singleton is a class which has only a one instance
        private static MyLogger instance;
        private static Logger logger;
        public static MyLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new MyLogger();
            }
            return  instance;
        }
        public Logger GetLogger()
        {
            if (logger == null)
            {
                logger = LogManager.GetLogger("RegisterLoginAppRule");
            }
            return logger;
        }
        public void Debug(string message)
        {
            GetLogger().Debug(message);
        }

        public void Error(string message)
        {
            GetLogger().Error(message);
        }

        public void Info(string message)
        {
            GetLogger().Info(message);
        }

        public void Warning(string message)
        {
            GetLogger().Warn(message);
        }
    }
}
