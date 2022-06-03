using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    internal interface ILogger : IDisposable
    {
        void Log(params string[] messages); // string jest z małej a na dirasku z dużej
    }
}
