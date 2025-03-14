using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz6
    {
        public void caso6()
        {
            
                Console.Write("Digite o número de linhas da matriz: ");
                int linhas = int.Parse(Console.ReadLine());
                Console.Write("Digite o número de colunas da matriz: ");
                int colunas = int.Parse(Console.ReadLine());

              
                int[,] matrizOriginal = new int[linhas, colunas];

                Console.WriteLine("Digite os elementos da matriz:");
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                        matrizOriginal[i, j] = int.Parse(Console.ReadLine());
                    }
                }

              
                int[,] matrizTransposta = new int[colunas, linhas];

            
                for (int i = 0; i < colunas; i++)
                {
                    for (int j = 0; j < linhas; j++)
                    {
                        matrizTransposta[i, j] = matrizOriginal[j, i];
                    }
                }

              
                Console.WriteLine("\nMatriz transposta:");
                for (int i = 0; i < colunas; i++)
                {
                    for (int j = 0; j < linhas; j++)
                    {
                        Console.Write(matrizTransposta[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
