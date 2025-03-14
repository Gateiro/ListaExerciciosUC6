using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz2
    {
        public void caso2()
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] matrizResultado = new int[2, 2];

            
            Console.WriteLine("Digite os elementos da matriz A:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Digite o elemento [{i},{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDigite os elementos da matriz B:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Digite o elemento [{i},{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrizResultado[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        matrizResultado[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            
            Console.WriteLine("\nMatriz resultante da multiplicação:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrizResultado[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
