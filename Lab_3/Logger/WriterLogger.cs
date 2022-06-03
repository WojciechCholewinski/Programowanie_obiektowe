using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        public int x;
        protected TextWriter writer;

        public abstract void Dispose();

        public virtual void Log(params string[] messages)
        {


            // TODO: Uzupełnić to miejsce o logikę zapisu opartą o TextWriter ...
            //TextWriter writer = new TextWriter("abc.txt", true);
            //StreamWriter writer = new StreamWriter("123.txt", true);
            writer.Write(messages);
            writer.Close();

            //StreamWriter writer = File.CreateText("../../newfilel.txt");
            //writer.Write(messages);
        }
    }
}
