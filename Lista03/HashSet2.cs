using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class HashSet2
    {
        public void caso2()
        {
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> uniaoConjuntos = new HashSet<int>();

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

            
            uniaoConjuntos.UnionWith(conjunto1);
            uniaoConjuntos.UnionWith(conjunto2);

            Console.WriteLine("\nConjunto resultante da união:");
            foreach (int elemento in uniaoConjuntos)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
