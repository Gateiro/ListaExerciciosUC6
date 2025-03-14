using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class HashSet4
    {
        public void caso4()
        {
            HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };
            HashSet<int> diferenca = new HashSet<int>();

            
            diferenca = conjuntoA.Except(conjuntoB).ToHashSet();

            Console.WriteLine("Elementos que estão em A mas não em B:");
            foreach (int elemento in diferenca)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
