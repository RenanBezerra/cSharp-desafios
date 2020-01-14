using System;
using System.Collections.Generic;
using System.Text;

namespace desafio4
{
   public class VideoGame : Produto 
    {
        //atributos	
        private String marca { get; set; }
        private String modelo { get; set; }
        private Boolean isUsado { get; set; }

        public VideoGame(string nome, Double preco, int qtd,string marca, string modelo, bool isUsado) :
            base( nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public VideoGame()
        {
        }


    }




}
