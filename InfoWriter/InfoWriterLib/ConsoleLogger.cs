using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWriterLib
{
    public class ConsoleLogger : ILogger
    {
        public void WriteInfo(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}