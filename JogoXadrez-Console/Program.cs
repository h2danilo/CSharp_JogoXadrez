using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


                Tela.imprimirTabuleiro(partida.tab);

                //Console.WriteLine("Posição : "+P);
                
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
