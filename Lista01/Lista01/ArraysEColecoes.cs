using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class ArraysEColecoes
    {
        public void cincoNumeros()
        {

            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }

            int soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }

            Console.WriteLine($"A soma de todos os valores é {soma}");
        }

        public void nomesAlunos()
        {
            List<string> alunos = new List<string>();

            string nome;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Insira o nome do {i}º aluno: ");
                nome = Console.ReadLine();
                alunos.Add(nome);
            }

            alunos.Sort();

            Console.WriteLine("\nAlunos em ordem alfabética:");
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
