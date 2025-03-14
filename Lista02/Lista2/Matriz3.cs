using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz3
    {
        public void caso3()
        {
             Console.Write("Digite a ordem da matriz identidade: ");
                int ordem = int.Parse(Console.ReadLine());

               
                int[,] matrizIdentidade = new int[ordem, ordem];

                
                for (int i = 0; i < ordem; i++)
                {
                    for (int j = 0; j < ordem; j++)
                    {
                        if (i == j)
                        {
                            matrizIdentidade[i, j] = 1;
                        }
                        else
                        {
                            matrizIdentidade[i, j] = 0;
                        }
                    }
                }

                
                Console.WriteLine("Matriz identidade:");
                for (int i = 0; i < ordem; i++)
                {
                    for (int j = 0; j < ordem; j++)
                    {
                        Console.Write(matrizIdentidade[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    