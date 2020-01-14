using System;
using System.Collections.Generic;
using System.Text;

namespace desafio2
{
    class Carro : Veiculo
    {
        private String marca { get; set; }
        private int portas { get; set; }
        private int ano { get; set; }

        public Carro(string modelo, int velocidade,
            string passageiro, float combustivel,
            string marca, int portas, int ano) : 
            base(modelo,velocidade,passageiro,combustivel)
        {
            this.marca = marca;
            this.portas = portas;
            this.ano = ano;
        }
        public  void status()
        {
            base.status();
            Console.WriteLine("Marca: "+ this.marca);
            Console.WriteLine("Portas: "+ this.portas);
            Console.WriteLine("Ano: "+ this.ano);
        }

    }
}
