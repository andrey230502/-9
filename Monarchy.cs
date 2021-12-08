using System;
using System.Collections.Generic;
using System.Text;

namespace лаба_9
{
    class Monarchy: State
    {
        private string wr;
        public Monarchy(string tog, string wr) : base(tog)
        {

           base.Tog=tog;
            this.wr = wr;

            
        }

        public string Wr { get => wr; set => wr = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Who rules = {wr}");

        }
    }
}
