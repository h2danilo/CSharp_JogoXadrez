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
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 5));

                Tela.imprimirTabuleiro(tab);

                //Console.WriteLine("Posição : "+P);
                
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
