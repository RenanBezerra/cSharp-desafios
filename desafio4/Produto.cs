using System;
using System.Collections.Generic;
using System.Text;

namespace desafio4
{
     abstract class Produto
    {
        //atributos	
        protected String nome { get; set; }
        protected Double preco { get; set; }
        protected int qtd { get; set; }
        
        
        //construtor
        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public Produto()
        {

        }



    }
}
