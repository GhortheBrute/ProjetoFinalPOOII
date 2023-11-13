using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalPOOII
{
    public class Baralho
    {
        public List<Carta> cartas { get; set; }
        public Baralho()
        {
            cartas = new List<Carta>();
            IniciaBaralho();
            EmbaralhaBaralho();
            ImprimeBaralho();
        }
        public void IniciaBaralho()
        {
            for (byte i = 0; i < 10; i++)
            {
                cartas.Add(new Carta(Cores.Vermelho, i));
            }
            for (byte i = 0; i < 10; i++)
            {
                cartas.Add(new Carta(Cores.Amarelo, i));
            }
            for (byte i = 0; i < 10; i++)
            {
                cartas.Add(new Carta(Cores.Azul, i));
            }
            for (byte i = 0; i < 10; i++)
            {
                cartas.Add(new Carta(Cores.Verde, i));
            }
            cartas.Add(new CartaBloqueio(Cores.Vermelho));
            cartas.Add(new CartaBloqueio(Cores.Vermelho));
            cartas.Add(new CartaBloqueio(Cores.Verde));
            cartas.Add(new CartaBloqueio(Cores.Verde));
            cartas.Add(new CartaBloqueio(Cores.Azul));
            cartas.Add(new CartaBloqueio(Cores.Azul));
            cartas.Add(new CartaBloqueio(Cores.Amarelo));
            cartas.Add(new CartaBloqueio(Cores.Amarelo));

            cartas.Add(new CartaComprarDois(Cores.Vermelho));
            cartas.Add(new CartaComprarDois(Cores.Vermelho));
            cartas.Add(new CartaComprarDois(Cores.Verde));
            cartas.Add(new CartaComprarDois(Cores.Verde));
            cartas.Add(new CartaComprarDois(Cores.Azul));
            cartas.Add(new CartaComprarDois(Cores.Azul));
            cartas.Add(new CartaComprarDois(Cores.Amarelo));
            cartas.Add(new CartaComprarDois(Cores.Amarelo));

            cartas.Add(new CartaComprarQuatro(Cores.Vermelho));
            cartas.Add(new CartaComprarQuatro(Cores.Verde));
            cartas.Add(new CartaComprarQuatro(Cores.Azul));
            cartas.Add(new CartaComprarQuatro(Cores.Amarelo));

            cartas.Add(new CartaInverter(Cores.Vermelho));
            cartas.Add(new CartaInverter(Cores.Vermelho));
            cartas.Add(new CartaInverter(Cores.Verde));
            cartas.Add(new CartaInverter(Cores.Verde));
            cartas.Add(new CartaInverter(Cores.Azul));
            cartas.Add(new CartaInverter(Cores.Azul));
            cartas.Add(new CartaInverter(Cores.Amarelo));
            cartas.Add(new CartaInverter(Cores.Amarelo));

            cartas.Add(new CartaCoringa(Cores.Vermelho));
            cartas.Add(new CartaCoringa(Cores.Verde));
            cartas.Add(new CartaCoringa(Cores.Azul));
            cartas.Add(new CartaCoringa(Cores.Amarelo));
        }
        public void EmbaralhaBaralho()
        {
            //Random rng = new Random();
            //cartas.OrderBy(a => Guid.NewGuid());
            Random rng = new Random();
            Carta embaralhaCarta;
            for (int n = (cartas.Count - 1); n > 1; n--)
            {
                int k = rng.Next(n + 1);
                embaralhaCarta = cartas[k];
                cartas[k] = cartas[n];
                cartas[n] = embaralhaCarta;

            }
        }
        public void ImprimeBaralho()
        {
            foreach (Carta carta in cartas)
            {
                Console.WriteLine($"Cor:\t{carta.Cor}.\nValor:\t{carta.Valor}");
            }
        }



    }
}
