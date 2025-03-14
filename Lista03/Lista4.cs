using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Lista4
    {
        public void caso4()
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

            int maior = numeros[0];
            int menor = numeros[0];

            
            for (int i = 1; i < numeros.Count; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine($"O maior valor é: {maior}");
            Console.WriteLine($"O menor valor é: {menor}");
        }
    }
}
