using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo("General Motors", "Spin", "ELW4025", "branca", 15.00f, 30.00);
            Veiculo v2 = new Veiculo();
            Console.WriteLine("Hello World!");
            v1.status();
            Console.WriteLine("--------------------------------");
            v2.status();


            v1.pintar("azul");
            Console.WriteLine("--------------------------------");
            v1.abastecer(30);
            v1.status();
            Console.WriteLine("--------------------------------");
            v2.status();
        }
    }
}
