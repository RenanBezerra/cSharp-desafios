using System;
using System.Collections.Generic;
using System.Text;

namespace desafio2
{
    class Aviao:Veiculo
    {
        //Atributos
        private String tipo { get; set; }
        private String uso { get; set; }

        public Aviao(string modelo, int velocidade,
            string passageiro, float combustivel,
            string tipo, string uso) : base(modelo,
                velocidade, passageiro, combustivel)
        {
            this.tipo = tipo;
            this.uso = uso;
        }
        
        public  void status()
        {
            base.status();
                       
            Console.WriteLine("Tipo: " + this.tipo);
            Console.WriteLine("Uso: " + this.uso);

        }

        //construtor


    }
}
