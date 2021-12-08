using System;
using System.Collections.Generic;
using System.Text;

namespace лаба_9
{
    class Republic: State
    {
        private string wr;

        public Republic(string tog, string wr): base(tog)
        {
            base.Tog = tog;
            this.wr = wr;
            
        }
        
        public string Wr { get => Wr; set => Wr = value; }
        
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Who rules: {wr}");

        }
    }
}
