using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz7
    {
        public void caso7()
        {
            
            int[,] matriz = new int[3, 3];

            
            Console.WriteLine("Digite os elementos da matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\nDiagonal principal:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            
            Console.WriteLine("\nDiagonal secundária:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matriz[i, 2 - i] + " ");
            }
        }
    }
}
