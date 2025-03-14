using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Lista2
    {
        public void caso2()
        {
            List<int> numeros = new List<int>();
            int soma = 0;

            Console.Write("Digite a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números:");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
                soma += numero;
            }

            
            string listaString = string.Join(", ", numeros);

            Console.WriteLine($"A lista de números é: {listaString}");
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
