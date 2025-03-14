using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Lista6
    {
        public void caso6()
        {
            List<int> numeros = new List<int>();

            Console.Write("Digite a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números:");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

        
            List<int> numerosInvertidos = new List<int>();

            
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                numerosInvertidos.Add(numeros[i]);
            }

            
            Console.WriteLine("\nLista original:");
            Console.WriteLine(string.Join(", ", numeros));

            Console.WriteLine("\nLista invertida:");
            Console.WriteLine(string.Join(", ", numerosInvertidos));
        }
    }
}
