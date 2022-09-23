using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Matriz modelo"
            int[,] iMatriz =  new int[3,3];

            //Ordenada por Linha - Coluna
            iMatriz[0, 1] = 10;
            iMatriz[1, 1] = 20;

            Console.WriteLine("A matriz resultante será semelhante a essa: ");
            Console.WriteLine("[" + iMatriz[0,0] +" "+ iMatriz[0, 1] +"]");
            Console.Write("[" + iMatriz[1, 0] + " " + iMatriz[1, 1] +"]");
            #endregion

            Console.WriteLine("\nPrecione ENTER para iniciar a multiplicação de matrizes");
            Console.ReadKey();

            int[,] iMatriz01 =  new int[2,3];
            int[,] iMatriz02 = new int[3,2];

            int[,] iResultado = new int[2, 2];

            Console.WriteLine("\nInforme os dados para preencher a Matriz-01 do tipo 3x2: ");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("1. - Posição [" + linha + "][" + coluna + "]: ");
                    iMatriz01[linha, coluna] = int.Parse(Console.ReadLine());//Preechendo a matriz 1
                }
            }


            Console.WriteLine("\nInforme os dados para preencher a Matriz-02 do tipo 3x2: ");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("2. - Posição [" + linha + "][" + coluna + "]: ");
                    iMatriz02[linha, coluna] = int.Parse(Console.ReadLine());//Preechendo a matriz 2
                }
            }


            Console.WriteLine("\nO resultado de Matriz01xMatriz02 é: ");
            iResultado[0, 0] = (iMatriz01[0, 0] * iMatriz02[0, 0] + (iMatriz01[0, 1] * iMatriz02[1, 0]) + (iMatriz01[0, 2] * iMatriz02[2, 0]));
            iResultado[1, 0] = (iMatriz01[1, 0] * iMatriz02[0, 0] + (iMatriz01[1, 1] * iMatriz02[1, 0]) + (iMatriz01[1, 2] * iMatriz02[2, 0]));
            iResultado[0, 1] = (iMatriz01[0, 0] * iMatriz02[0, 1] + (iMatriz01[0, 1] * iMatriz02[1, 1]) + (iMatriz01[0, 2] * iMatriz02[2, 1]));
            iResultado[1, 1] = (iMatriz01[1, 0] * iMatriz02[0, 1] + (iMatriz01[1, 1] * iMatriz02[1, 1]) + (iMatriz01[1, 2] * iMatriz02[2, 1]));

            Console.WriteLine("               [" + iResultado[0,0] + "][" + iResultado[0,1] + "]");
            Console.WriteLine("               [" + iResultado[1, 0] + "][" + iResultado[1, 1] + "]");


            Console.ReadKey(); 

        }
    }
}
