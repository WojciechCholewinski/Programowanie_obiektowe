using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    public class ConsoleLogger : WriterLogger
    {
        
        
        public ConsoleLogger()
        {
            Console.Write(DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss+00:00"));
        }
        public override void Dispose()
        {

        }
    }
}
