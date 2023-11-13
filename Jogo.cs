using System;
using System.Collections;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;


namespace JogoDeCartasUno
{
    public class Jogo
    {
        public List<Jogador> Jogadores {get; set;}
        public Jogador JogadorAtual {get;set;}
        public Baralho Baralho{get; set;}
        public List<Cartas> cartasDescartadas;
        public Jogo()
        {
            Jogadores = new List<Jogador>();
            Jogadores.Add(new Jogador{Nome = "Jogador1"});
            Jogadores.Add(new Jogador{Nome = "Jogador2"});
            Jogadores.Add(new Jogador{Nome = "Jogador3"});
            Jogadores.Add(new Jogador{Nome = "Jogador4"});
            cartasDescartadas = new List<Cartas>();
            Baralho = new Baralho();
            IniciarJogo();
        }
        public void IniciarJogo()
        {
            foreach (Jogador jogador in Jogadores)
            {
                for (int i = 0; i < 7; i++)
                {
                    jogador.ComprarCarta(this);
                }
            }
            Cartas primeiraCarta = Baralho.PegarCarta();
            cartasDescartadas.Add(primeiraCarta);
            ProximoJogador();
        }
        public Jogador ProximoJogador()
        {
            int posicao = Jogadores.IndexOf(JogadorAtual);
            posicao++;
            if (posicao >= Jogadores.Count)
            {
                posicao = 0;
            }
            return Jogadores[posicao];
        }
        public void InverterOrdem()
        {
            Jogadores.Reverse();
        }
        public Cartas UltimaCartaDescartada()
        {
            return cartasDescartadas[cartasDescartadas.Count-1];
        }
    }
}