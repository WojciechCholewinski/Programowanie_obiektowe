using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Net;
//using System.Net.Sockets;
namespace Lab_3.Logger
{
    public class FileLogger : WriterLogger
    {
        ~FileLogger()
        {
            writer.Close();
        }

        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            //TextWriter writer = new StreamWriter(path, true);
            
            

        }

        public override void Dispose()
        {
            
        }
    }
}
