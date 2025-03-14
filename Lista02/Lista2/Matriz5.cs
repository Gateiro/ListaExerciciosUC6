using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz5
    {
        public void caso5()
        {
            int[,] matriz = new int[4, 4];

            
            Console.WriteLine("Digite os elementos da matriz 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\nSoma de cada linha:");
            for (int i = 0; i < 4; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < 4; j++)
                {
                    somaLinha += matriz[i, j];
                }
                Console.WriteLine($"Linha {i + 1}: {somaLinha}");
            }

            
            Console.WriteLine("\nSoma de cada coluna:");
            for (int j = 0; j < 4; j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < 4; i++)
                {
                    somaColuna += matriz[i, j];
                }
                Console.WriteLine($"Coluna {j + 1}: {somaColuna}");
            }
        }
    }
}
