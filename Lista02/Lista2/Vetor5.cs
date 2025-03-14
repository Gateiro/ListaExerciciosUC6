using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Vetor5
    {
        public void caso5()
        {
            int[] numeros = { 64, 34, 25, 12, 22, 11, 90 };

            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        // Troca os elementos de lugar
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            // Mostra o vetor ordenado
            Console.WriteLine("Vetor ordenado:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
        }


    }
}
