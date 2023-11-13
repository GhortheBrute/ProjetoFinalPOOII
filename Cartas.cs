namespace JogoDeCartasUno
{
        public class Cartas
    {
        public Cores Cor { get; set; }
        public int Valor { get; set; }

        public Cartas(Cores cor, int valor)
        {
            Cor = cor;
            Valor = valor;
        }
        public virtual bool Combinacao(Cartas carta)
        {
            return carta.Valor == this.Valor || carta.Cor == this.Cor;
        }
        public virtual void Acao(Jogo jogo){}
    }
}