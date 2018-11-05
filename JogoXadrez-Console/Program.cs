using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace JogoXadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posicao P = new Posicao(3,4);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            //Console.WriteLine("Posição : "+P);
            Console.ReadLine();

            
        }
    }
}
