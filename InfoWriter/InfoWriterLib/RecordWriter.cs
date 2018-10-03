using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoWriterLib
{

    //<summary>
    //API
    //</summary>
    public class RecordWriter
    {
        private ILogger writer = null;

        public RecordWriter(ILogger writer)
        {
            this.writer = writer;
        }

        public void WriteRecord(string msg)
        {
            this.writer.WriteInfo(msg);
        }
    }
}
