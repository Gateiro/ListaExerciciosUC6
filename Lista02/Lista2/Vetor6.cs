using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Vetor6
    {
        public void caso6()
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


            int tamanhoMaximo = numeros.Length;
            int[] pares = new int[tamanhoMaximo];
            int[] impares = new int[tamanhoMaximo];

            int indicePares = 0;
            int indiceImpares = 0;

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares[indicePares] = numero;
                    indicePares++;
                }
                else
                {
                    impares[indiceImpares] = numero;
                    indiceImpares++;
                }
            }

            Console.WriteLine("Números Pares:");
            for (int i = 0; i < indicePares; i++)
            {
                Console.WriteLine(pares[i]);
            }


            Console.WriteLine("Números Ímpares:");
            for (int i = 0; i < indiceImpares; i++)
            {
                Console.WriteLine(impares[i]);
            }
        }
    }
}
