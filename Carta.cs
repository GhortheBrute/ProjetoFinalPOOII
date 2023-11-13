using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalPOOII
{
    public class Carta
    {
        public Cores Cor { get; set; }
        public int Valor { get; set; }

        public Carta(Cores cor, int valor)
        {
            Cor = cor;
            Valor = valor;
        }
    }
}
