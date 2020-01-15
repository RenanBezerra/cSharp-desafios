using System;
using System.Collections.Generic;
using System.Text;

namespace desafio3
{
    class Caminhao : Veiculo
    {
        //atributos
        int carga { get; set; }
        int eixos { get; set; }

        public Caminhao(string modelo, string marca, string placa,
            string cor, int km, bool isLigado,
            int litrosCombustivel, int velocidade, double preco, int carga, int eixos) : 
            base(modelo, marca, placa, cor, km,
                isLigado, litrosCombustivel, velocidade, preco)
        {
            this.carga = carga;
            this.eixos = eixos;

        }

        public Caminhao()
        {

        }




        //metodos
        public void abastecer(float qua)
        {
            this.litrosCombustivel += (int)qua;
        }
        public void acelerar()
        {
            base.acelerar();
            this.velocidade += 50;
        }
        public void status()
        {
            base.status();
            Console.WriteLine("Carga: " + this.carga +
                "\nEixos: " + this.eixos);
           
        }


    }
}
