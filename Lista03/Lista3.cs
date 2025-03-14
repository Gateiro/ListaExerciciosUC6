using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Lista3
    {
        public void caso3()
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

            
            List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("\nLista original:");
            Console.WriteLine(string.Join(", ", numeros));

            Console.WriteLine("\nLista de números pares:");
            Console.WriteLine(string.Join(", ", numerosPares));
        }
    }
}
