using System;
using System.Collections.Generic;
using System.Text;

namespace desafio2
{
     public abstract class Veiculo
    {
        //atributos
        private String modelo { get; set; }
        private int velocidade { get; set; }
        private String passageiro { get; set; }
        private float combustivel { get; set; }

        public Veiculo(string modelo, int velocidade,
            string passageiro, float combustivel)
        {
            this.modelo = modelo;
            this.velocidade = velocidade;
            this.passageiro = passageiro;
            this.combustivel = combustivel;
        }

        public Veiculo()
        {
        }

        public void status()
        {
            Console.WriteLine("O veiculo modelo: " + this.modelo);
            Console.WriteLine("Velocidade: " + this.velocidade);
            Console.WriteLine("Passageiro: " + this.passageiro);
            Console.WriteLine("Combustivel " + this.combustivel);
               
        }
    }
}
