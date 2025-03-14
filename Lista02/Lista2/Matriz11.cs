using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz11
    {
        public void caso11()
        {
            int[,] matriz = new int[3, 3];
            int produto = 1;

            Console.WriteLine("Digite os elementos da matriz 3x3:");
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
                produto *= matriz[i, i];
            }

            Console.WriteLine($"O produto dos elementos da diagonal principal é: {produto}");
        }
    }
}
