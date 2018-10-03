using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoWriterLib;

namespace InfoWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new ConfigurationLoggerFactory();
            ILogger logger = loggerFactory.Create();

            var recordWrite = new RecordWriter(logger);

            recordWrite.WriteRecord("Hello World");

            Console.Read();
        }
    }
}
