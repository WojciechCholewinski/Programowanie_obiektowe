using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    internal class SocketLogger : ILogger
    {
        private ClientSocket[] clientSocket;
        ~SocketLogger()
        {

        }
        protected string host;  // nie ma tego na diagramie
        protected int port;     // nie ma tego na diagramie

        public SocketLogger(string host, int port)
        {
            this.host = host;   // nie ma tego na diagramie
            this.port = port;   // nie ma tego na diagramie
        }

        public void Dispose()
        {
            
        }

        public void Log(params string[] messages)
        {
            
        }
    }
}
