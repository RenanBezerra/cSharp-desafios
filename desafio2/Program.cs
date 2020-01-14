using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------------------------");
            Carro c1 = new Carro("zafira", 0, "Renan", 50.00f, "GM", 4, 2017);
            c1.status();
            Console.WriteLine("----------------------------");
            Aviao a1 = new Aviao("boing", 0, "Pedro", 100f, "grande", "comercial");
            a1.status();

        }
    }
}
