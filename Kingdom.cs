using System;
using System.Collections.Generic;
using System.Text;

namespace лаба_9

{
    class Kingdom: Monarchy
    {
        private int num;
        public Kingdom( string tog,  string wr, int num) : base( tog,  wr)
        {
            
            base.Tog=tog;
            this.Wr = wr;
            this.num = num;

            
        }

        public int Num { get => num; set => num = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Кількість правителів = {num}");

        }
    }
}
