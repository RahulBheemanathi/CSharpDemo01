using System;
using InfoWriterLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfoWriteLibTests
{
    [TestClass]
    public class RecordWriterTests
    {
        [TestMethod]
        public void RecordWriter_Uses_ILogger_To_Write()
        {
            var logger = new TestLogger();
            string messageToWrite = "Hello";

            RecordWriter recordWriter = new RecordWriter(logger);
            recordWriter.WriteRecord(messageToWrite);

            Assert.AreEqual<string>(messageToWrite, logger.Message);
        }
    }

    public class TestLogger : ILogger
    {
        public string Message { get; set; }

        public TestLogger()
        {
            this.Message = null;
        }

        public void WriteInfo(string msg)
        {
            this.Message = msg;
        }
    }
}
