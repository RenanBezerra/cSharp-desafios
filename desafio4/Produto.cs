using System;
using System.Collections.Generic;
using System.Text;

namespace desafio4
{
     abstract class Produto
    {
        protected String nome;
        protected double preco;
        protected int qtd;

        //atributos	getters e setters
        public String Nome { get; set; }
        public Double Preco { get; set; }
        public int Qtd { get; set; }
        
        
        //construtor
        public Produto(String nome, Double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }

        public Produto()
        {

        }



    }
}
