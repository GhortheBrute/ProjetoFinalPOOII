using System.Diagnostics.Contracts;

namespace JogoDeCartasUno
{
    public class CartaComprarDois : Cartas
    {
        public CartaComprarDois(Cores cor) : base (cor,  -1){}

        public override bool Combinacao(Cartas carta)
        {
            return carta is CartaComprarDois || carta.Cor == this.Cor;
        }
        public override void Acao(Jogo jogo)
        {
            
            for (int i = 0; i < 2; i++)
            {
                jogo.ProximoJogador().ComprarCarta(jogo);
            }

            
        }
    }
}