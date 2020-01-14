using System;
using System.Collections.Generic;
using System.Text;

namespace desafio3
{
    class Veiculo
    {
        // atributos
        protected String modelo { get; set; }
        protected String marca { get; set; }
        protected String placa { get; set; }
        protected String cor { get; set; }
        protected int km { get; set; }
        protected Boolean isLigado { get; set; }
        protected int litrosCombustivel { get; set; }
        protected int velocidade { get; set; }
        protected double preco { get; set; }

        public Veiculo(string modelo, string marca, string placa,
            string cor, int km, bool isLigado,
            int litrosCombustivel, int velocidade, double preco)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.placa = placa;
            this.cor = cor;
            this.km = km;
            this.isLigado = isLigado;
            this.litrosCombustivel = litrosCombustivel;
            this.velocidade = velocidade;
            this.preco = preco;
        }

        public Veiculo()
        {
        }

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
            if (this.litrosCombustivel < 100)
            {
                if (this.litrosCombustivel + li > 100)
                {
                    this.litrosCombustivel = 100;
                    dif = li - 50;
                    Console.WriteLine("Não pode exceder o limite de combustivel");
                    Console.WriteLine("Excedeu em " + dif + "litros de combustivel");
                }
                else
                {
                    this.litrosCombustivel += li;
                    Console.WriteLine("Abastecimento de " + li + " litros concluido, a quantidade de combustivel é " + this.litrosCombustivel + " litros");
                }

            }
            else
            {
                Console.WriteLine("Não é possivel abastecer o tanque está cheio");

            }

        }

        public void frear()
        {
            if (this.isLigado == true)
            {
                if (this.velocidade < 0)
                {
                    Console.WriteLine("O carro está parado");
                }
                else
                {
                    this.velocidade -= 10;
                }
            }
            else
            {
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
