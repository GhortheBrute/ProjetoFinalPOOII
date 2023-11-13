using System.Diagnostics.Contracts;

namespace JogoDeCartasUno
{
    public class CartaBloqueio : Cartas
    {
        public CartaBloqueio(Cores cor) : base (cor,  -1){}

        public override bool Combinacao(Cartas carta)
        {
            return carta is CartaBloqueio || carta.Cor == this.Cor;
        }
        public override void Acao(Jogo jogo)
        {
            jogo.ProximoJogador().Bloquear();
        }
    }
}