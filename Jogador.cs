namespace JogoDeCartasUno
{
    public class Jogador
    {
        public string Nome { get; set; }
        private bool Bloqueado = false;
        public List<Cartas> cartas { get; set;}
        public Jogador()
        {
            cartas = new List<Cartas>();
        }
        public void ComprarCarta(Jogo jogo)
        {
            cartas.Add(jogo.Baralho.PegarCarta());
        }
        public void Bloquear()
        {
            Bloqueado = true;
        }
        public bool JogadorBloqueado()
        {
            bool bloqueado = this.Bloqueado;
            bloqueado = false;
            return bloqueado;
        }
    }
}