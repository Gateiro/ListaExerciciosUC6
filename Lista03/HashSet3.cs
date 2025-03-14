using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class HashSet3
    {
        public void caso3()
        {
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> intersecaoConjuntos = new HashSet<int>();

            Console.WriteLine("Digite os elementos do primeiro conjunto (digite um número negativo para parar):");
            int numero;
            while ((numero = int.Parse(Console.ReadLine())) >= 0)
            {
                conjunto1.Add(numero);
            }

            Console.WriteLine("\nDigite os elementos do segundo conjunto (digite um número negativo para parar):");
            while ((numero = int.Parse(Console.ReadLine())) >= 0)
            {
                conjunto2.Add(numero);
            }

            
            intersecaoConjuntos = conjunto1.Intersect(conjunto2).ToHashSet();

            Console.WriteLine("\nConjunto resultante da interseção:");
            foreach (int elemento in intersecaoConjuntos)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
