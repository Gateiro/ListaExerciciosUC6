using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    public class Dicionario1
    {
        public void caso1()
        {
            Dictionary<string, string> contatos = new Dictionary<string, string>();

            Console.WriteLine("---- DICIONARIO ----");
            Console.WriteLine("Digite o número de contatos que deseja adicionar:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o nome do contato {i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite o telefone de {nome}: ");
                string telefone = Console.ReadLine();

                contatos.Add(nome, telefone);
            }

            Console.WriteLine("\nContatos adicionados:");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"{contato.Key}: {contato.Value}");
            }
        }
    }
}
