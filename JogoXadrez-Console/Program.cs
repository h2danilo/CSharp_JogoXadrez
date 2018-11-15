using System;
using tabuleiro;
using xadrez;

namespace JogoXadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posicao P = new Posicao(3,4);
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                 while (!partida.terminada) {

                    try {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando Jogada: " + partida.JogadorAtual);

                        Console.WriteLine();
                        Console.Write("origem:");
                        Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("destino:");
                        Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);

                    } catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }


                

                //Console.WriteLine("Posição : "+P);
                
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
