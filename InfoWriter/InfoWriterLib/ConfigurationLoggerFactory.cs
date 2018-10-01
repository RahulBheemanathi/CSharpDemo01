using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWriterLib
{
    public class ConfigurationLoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            var loggerType = ConfigurationManager.AppSettings.Get("LoggerType");
            ILogger logger = null;

            switch (loggerType)
            {
                case "Console":
                    logger = new ConsoleLogger();
                    break;
                case "File":
                    logger = new FileLogger();
                    break;
                default:
                    logger = new ConsoleLogger();
                    break;
            }

            return logger;
        }
    }
}
