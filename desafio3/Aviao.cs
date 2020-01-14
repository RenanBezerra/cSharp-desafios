using System;
using System.Collections.Generic;
using System.Text;

namespace desafio3
{
    class Aviao : Veiculo
    {
        //atributos
        private String tipo { get; set; }
        private String uso { get; set; }

        public Aviao(string modelo, string marca, string placa,
            string cor, int km, bool isLigado,
            int litrosCombustivel, int velocidade, double preco, string tipo, string uso) :
            base(modelo, marca, placa, cor, km,
                isLigado, litrosCombustivel, velocidade, preco)

        {
            this.tipo = tipo;
            this.uso = uso;
        }

        public Aviao()
        {
        }


        //metodos
        public void abastecer(String quant)
        {
            this.litrosCombustivel += int.Parse(quant);
        }
        public void acelerar()
        {
            base.acelerar();
        }
        public void status()
        {
            base.status();
            Console.WriteLine("Tipo: " + this.tipo); 
                Console.WriteLine( "Uso: " + this.uso);
        }

    }
}
