using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz12
    {
        public void caso12()
        {
             int[,] matriz = new int[5, 5];
                int soma = 0;

                Console.WriteLine("Digite os elementos da matriz 5x5:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                
                for (int i = 0; i < 5; i++)
                {
                    soma += matriz[i, 0] + matriz[i, 4]; 
                }
                for (int j = 1; j < 4; j++)
                {
                    soma += matriz[0, j] + matriz[4, j]; 
                }

                Console.WriteLine($"A soma dos elementos das bordas é: {soma}");
            }
        }
    }
