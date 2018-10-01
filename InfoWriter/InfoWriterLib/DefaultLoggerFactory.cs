using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWriterLib
{
    public class DefaultLoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new ConsoleLogger();
        }
    }
}