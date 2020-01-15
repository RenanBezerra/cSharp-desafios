using System;
using System.Collections.Generic;
using System.Text;

namespace desafio4
{
    class Livro : Produto, Imposto
    {


        private String autor;
        private String tema;
        private int qtdPag;

        //atributos	getters e setters
        public String Autor { get; set; }
        public String Tema { get; set; }
        public int QtdPag { get; set; }

        public Livro(String nome, Double preco, int qtd, String autor, String tema, int qtdPag) :
            base(nome, preco, qtd)
        {

            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

       


        //metodo interface

        private double valorImp;
        public double ValorImp { get; set; }


        public double calculaImposto()
        {
            if (this.tema == "educativo")
            {
                Console.WriteLine("Livro educativo não tem imposto: " + this.Nome);
                return 0;
            }
            else
            {
                valorImp = this.Preco * 0.1;
                Console.WriteLine("Imposto: " + this.Nome + "é de R$ " + valorImp);
                return valorImp;
            }


        }
    }
}
