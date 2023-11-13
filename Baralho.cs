using System;
using System.Collections;

namespace JogoDeCartasUno
{
    public class Baralho
    {
        public List<Cartas> baralho { get; set; }
        public Baralho()
        {
            baralho = new List<Cartas>();
            IniciaBaralho();
            EmbaralhaBaralho();
            //ImprimeBaralho();
        }
        public void IniciaBaralho()
        {
            Cores[] colorido = (Cores[]) Enum.GetValues(typeof(Cores));
            foreach (Cores cor in colorido)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (byte i = 0; i < 10; i++)
                    {
                        baralho.Add(new Cartas(cor, i));
                    }
                }
                    
                baralho.Add(new CartaBloqueio(cor));
                baralho.Add(new CartaBloqueio(cor));

                baralho.Add(new CartaComprarDois(cor));
                baralho.Add(new CartaComprarDois(cor));

                baralho.Add(new CartaComprarQuatro(cor));
                
                baralho.Add(new CartaCoringa(cor));

                baralho.Add(new CartaInverter(cor));
                baralho.Add(new CartaInverter(cor));
            }
        }
        public void EmbaralhaBaralho()
        {
            Random random = new Random();
             
            for(int n = baralho.Count-1; n > 1; n--)
            {  
                int k = random.Next(n + 1);
                Cartas embaralhaCarta = baralho[n];
                
                baralho[k] = baralho[n];
                baralho[n] = embaralhaCarta;
                
            }  
        }
        public void ImprimeBaralho()
        {
            foreach (Cartas carta in baralho)
            {
                Console.WriteLine($"Cor:\t{carta.Cor}\nValor:\t{carta.Valor}\n");
            }
        }
        public bool TemCarta()
        {
            return baralho.Count > 0;
        }
        public Cartas PegarCarta()
        {
            Random random = new Random();
            int posicao = random.Next(0, baralho.Count-1);
            Cartas cartaNova = baralho[posicao];
            baralho.Remove(cartaNova);

            return cartaNova;
        }
    }

}