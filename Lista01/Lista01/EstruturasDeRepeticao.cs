using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class EstruturasDeRepeticao
    {
        public void deZeroACem()
        {
            Console.WriteLine("---- DE 0 À 100! ----");

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void tabuada()
        {
            Console.WriteLine("---- QUAL SERÁ A SUA TABUADA? ----");
            Console.WriteLine("Escolha um número de 1 à 10");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = num1 * i;
                Console.WriteLine($"{num1} X {i} = {resultado}");
            }
        }
    }

}
