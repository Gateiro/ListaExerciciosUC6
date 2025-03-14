using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz8
    {
        public void caso8()
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

            Console.Write("Digite o número que deseja buscar: ");
            int numeroBuscar = int.Parse(Console.ReadLine());

            
            bool encontrado = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] == numeroBuscar)
                    {
                        Console.WriteLine($"O número {numeroBuscar} foi encontrado na posição [{i},{j}]");
                        encontrado = true;
                    }
                }
            }

            
            if (!encontrado)
            {
                Console.WriteLine($"O número {numeroBuscar} não foi encontrado na matriz.");
            }
        }
    }
}
