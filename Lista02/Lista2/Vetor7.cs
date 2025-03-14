using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Vetor7
    {
        public static bool EhPalindromo(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            while (inicio < fim)
            {
                if (vetor[inicio] != vetor[fim])
                {
                    return false;
                }
                inicio++;
                fim--;
            }

            return true;
        }

        public void caso7()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            Console.WriteLine("Digite os números do vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"{i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            if (EhPalindromo(numeros))
            {
                Console.WriteLine("O vetor é um palíndromo.");
            }
            else
            {
                Console.WriteLine("O vetor não é um palíndromo.");
            }
        }

    }
}
