using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InfoWriterLib
{
    public class FileLogger : ILogger
    {
        public void WriteInfo(string msg)
        {
            using (var filewriter = new StreamWriter("Information.txt", true))
            {
                filewriter.WriteLine(msg + " " + DateTime.Now.ToString());
            }
        }
    }
}
