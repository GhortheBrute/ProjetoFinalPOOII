using System.Diagnostics.Contracts;

namespace JogoDeCartasUno
{
    public class CartaInverter : Cartas
    {
        public CartaInverter(Cores cor) : base (cor,  -1){}

        public override bool Combinacao(Cartas carta)
        {
            return carta is CartaInverter || carta.Cor == this.Cor;
        }
        public override void Acao(Jogo jogo)
        {
            jogo.InverterOrdem();
        }
    }
}