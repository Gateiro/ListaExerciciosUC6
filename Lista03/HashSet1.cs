using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class HashSet1
    {
        public void caso1()
        {
            HashSet<string> palavrasUnicas = new HashSet<string>();

            Console.Write("Digite a quantidade de palavras: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as palavras:");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Palavra {i + 1}: ");
                string palavra = Console.ReadLine();
                palavrasUnicas.Add(palavra);
            }

            Console.WriteLine("\nConjunto de palavras únicas:");
            foreach (string palavra in palavrasUnicas)
            {
                Console.WriteLine(palavra);
            }
        }
    }
}
