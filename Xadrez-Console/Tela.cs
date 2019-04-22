using System;
using tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            { 
                for(int j = 0; j<tab.Colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else { Console.Write(tab.peca(i, j) + " "); }
                }
                Console.WriteLine();

            }

            
        }

    }
}
