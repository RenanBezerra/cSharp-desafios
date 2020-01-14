using System;
using System.Collections.Generic;
using System.Text;

namespace desafio3
{
    class Carro : Veiculo
    {
      //atributos
        private int portas { get; set; }
        private int ano { get; set; }

        public Carro(string modelo, string marca, string placa,
            string cor, int km, bool isLigado,
            int litrosCombustivel, int velocidade, double preco, int portas, int ano) : 
            base(modelo,marca,placa,cor,km,
                isLigado,litrosCombustivel,velocidade,preco)
        {
            this.portas = portas;
            this.ano = ano;
        }

		public Carro()
		{
		}

		public void frear()
		{

			base.frear();
		}

		public void pintar(String cor)
		{

			base.pintar(cor);
		}

		public void ligar()
		{

			base.ligar();
		}

		public void desligar()
		{

			base.desligar();
		}

		// metodos
		public void abastecer(int li)
		{
			
			this.litrosCombustivel = li;
		}

		public void acelerar()
		{
			base.acelerar();
		}

		public void status()
		{
			base.status();
			Console.WriteLine("Portas: " + this.portas); 
			Console.WriteLine("Ano: " + this.ano);
		}
	

}
}
