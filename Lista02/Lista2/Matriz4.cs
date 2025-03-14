using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz4
    {
        public void caso4()
        {
                
                int[,] matriz = new int[3, 3];

                Console.WriteLine("Digite os valores na matriz 3x3:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

               
                for (int i = 0; i < 3; i++)
                {
                    int maiorValor = matriz[i, 0]; 

                    for (int j = 1; j < 3; j++)
                    {
                        if (matriz[i, j] > maiorValor)
                        {
                            maiorValor = matriz[i, j];
                        }
                    }

                    Console.WriteLine($"O maior valor da linha {i + 1} é: {maiorValor}");
                }
            }
        }
    }

