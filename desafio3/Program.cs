using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
			Carro c1 = new Carro();
			Carro c2 = new Carro("Fit", "Honda", "efr4987", "cinza", 10000, false, 40, 0, 40.9, 4, 2017);
			Aviao a1 = new Aviao();
			Aviao a2 = new Aviao("771", "boing", "7654rfde", "braca", 210000, false, 1000, 0, 500000, "grande", "comercial");
			Caminhao ca1 = new Caminhao();
			Caminhao ca2 = new Caminhao("S10", "Ford", "ret5421", "vermelho", 1000000, false, 60, 0, 350000, 4500, 6);
			Console.WriteLine("-------------------------------");
			c1.abastecer(40);
			a1.abastecer(40);
			ca1.abastecer(43.4f);
			c2.ligar();
			c2.status();
			Console.WriteLine("-------------------------------");
			c2.acelerar();
			ca2.acelerar();
			c1.ligar();

			Console.WriteLine("-------------------------------");
			c1.status();
			Console.WriteLine("-------------------------------");
			c2.status();
			Console.WriteLine("-------------------------------");
			a1.status();
			Console.WriteLine("-------------------------------");
			a2.status();
			Console.WriteLine("-------------------------------");
			ca1.status();
			Console.WriteLine("-------------------------------");
			ca2.status();
			Console.WriteLine("-------------------------------");
		}
    }
}
