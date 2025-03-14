using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Lista5
    {
        public void caso5()
        {
            List<int> numeros = new List<int>();
            HashSet<int> numerosUnicos = new HashSet<int>();

            Console.Write("Digite a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números:");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            numerosUnicos.UnionWith(numeros);

            Console.WriteLine("\nLista com números únicos:");
            Console.WriteLine(string.Join(", ", numerosUnicos));
        }
    }
}
