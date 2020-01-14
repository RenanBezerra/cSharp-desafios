using System;
using System.Collections.Generic;
using System.Text;

namespace desafio
{
    class Veiculo
    {
        //atributos
        private String marca { get; set; }
        private String modelo { get; set; }
        private String placa { get; set; }
        private String cor { get; set; }
        private float km { get; set; }
        private Boolean isLigado { get; set; }
        private int litrosCombustivel { get; set; }
        private int velocidade { get; set; }
        private double preco { get; set; }


        //construtor

        public Veiculo(String marca, String modelo, String placa,
            String cor, float km, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.km = km;
            this.isLigado = false;
            this.litrosCombustivel = 50;
            this.velocidade = 0;
            this.preco = preco;

        }
        public Veiculo()
        {

        }

        //metodos
        public void acelerar()
        {
            if (this.isLigado == true)
            {
                this.velocidade = this.velocidade + 20;
                this.litrosCombustivel -= 1;
            }
            else
            {
                Console.WriteLine("Não é possivel acelerar, o carro está desligado");
            }
        }
        int dif;
        public void abastecer(int li)
        {
            if (this.litrosCombustivel <100)
            {
                if (this.litrosCombustivel + li >100)
                {
                    this.litrosCombustivel = 100;
                    dif = li - 50;
                    Console.WriteLine("Não pode exceder o limite de combustivel");
                    Console.WriteLine("Excedeu em " + dif + "litros de combustivel");
                }
                else
                {
                    this.litrosCombustivel += li;
                    Console.WriteLine("Abastecimento de " + li + " litros concluido, a quantidade de combustivel é " + this.litrosCombustivel +" litros");
                }

            }
            else
            {
                Console.WriteLine("Não é possivel abastecer o tanque está cheio");

            }

        }

        public void frear()
        {
            if (this.isLigado == true) {
                if (this.velocidade < 0)
                {
                    Console.WriteLine("O carro está parado");
                }
                else
                {
                    this.velocidade -= 10;
                }
                     }
            else{
                Console.WriteLine("Não é possivel frear seu carro está desligado");
            }
        }
        public void pintar(String cor)
        {
            this.cor = cor;
        }
        public void ligar()
        {
            if (this.isLigado == false)
            {
                this.isLigado = true;
                Console.WriteLine("O carro ligou!!");
            }
            else
            {
                Console.WriteLine("O carro se encontra ligado.");
            }
        }
        public void desligar()
        {
            if (this.isLigado == true)
            {
                this.isLigado = false;
                Console.WriteLine("Desligando o carro");
            }
            else
            {
                Console.WriteLine("O carro está desligado");
            }
            

        }
        public void status()
        {

            Console.WriteLine("O veiculo modelo: " + this.modelo);
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Placa: " + this.placa);
            Console.WriteLine("Cor: " + this.cor);
            Console.WriteLine("Km: " + this.km);
            Console.WriteLine("Ligado: " + this.isLigado);
            Console.WriteLine("Litros de combustivel: " + this.litrosCombustivel);
            Console.WriteLine("Velocidade: " + this.velocidade);
            Console.WriteLine("Preço: " + this.preco);
        }

    }
}
