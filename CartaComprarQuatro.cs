using System.Diagnostics.Contracts;

namespace JogoDeCartasUno
{
    public class CartaComprarQuatro : Cartas
    {
        public CartaComprarQuatro(Cores cor) : base (cor,  -1){}

        public override bool Combinacao(Cartas carta)
        {
            return carta is CartaComprarQuatro || carta.Cor == this.Cor;
        }
        public override void Acao(Jogo jogo)
        {
            jogo.InverterOrdem();
        }
    }
}