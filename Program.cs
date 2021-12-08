using System;

namespace лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            State s1 = new State("Тип правління");
            Console.WriteLine("Клас State");
            s1.Print();
            Console.WriteLine();
            Republic r1 = new Republic("Республіка","Народ");
            Console.WriteLine("Клас Republic");
            r1.Print();
            Console.WriteLine();
            Monarchy m1 = new Monarchy("Монархія","Монарх");
            Console.WriteLine("Клас Monarchy");
            m1.Print();
            Console.WriteLine();
            Kingdom k1 = new Kingdom("Монархія", "Монарх",1);
            Console.WriteLine("Клас Kingdom");
            k1.Print();
            Console.WriteLine();
        }
    }
}
