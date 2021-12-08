using System;
using System.Collections.Generic;
using System.Text;

namespace лаба_9
{
    class State
    {
        private string tog;

        public State(string tog)
        {

            this.tog = tog;




        }
        public State(){ tog = "тип правління"; }

        public string Tog  { get => tog; set => tog = value; }   
        public  void Print()
        {

            
            Console.WriteLine($"Правління: {tog}");

        }
    }
}
