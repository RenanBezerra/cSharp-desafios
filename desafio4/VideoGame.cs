using System;
using System.Collections.Generic;
using System.Text;

namespace desafio4
{
    class VideoGame : Produto, Imposto
    {
        //atributos	
        private String marca;
        private String modelo;
        private bool isUsado;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }


        public VideoGame(String nome, Double preco, int qtd, String marca, String modelo, bool isUsado) :
            base(nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }

      
        public double calculaImposto()
        {
            if (this.IsUsado == false)
            {

                Console.WriteLine("Imposto : " + this.Nome + "  é R$: " + this.Preco * 0.45);
                return this.Preco * 0.45;
            }
            else
            {

                Console.WriteLine("Imposto: " + this.Nome + " usado é de R$: " + this.Preco * 0.25);
                return this.Preco * 0.25;
            }

        }
    }
}



