using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Lista1
    {
        public void caso1()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Digite 5 números inteiros:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            Console.WriteLine("Números digitados:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
