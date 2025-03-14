using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class POO
    { }

    public class  Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"A marca do carro é: {Marca}");
            Console.WriteLine($"O modelo do carro é: {Modelo}");
            Console.WriteLine($"O ano do carro é: {Ano}");
        }
    }

    public class CadastroCarro
    {
        public void cadastroCarro()
        {
            Carro novoCarro = new Carro();

            Console.WriteLine("--- CADASTRO DE VEÍCULO ---");
            Console.Write("Informe a marca do seu carro: ");
            novoCarro.Marca = Console.ReadLine();
            Console.Write("Informe o modelo do carro: ");
            novoCarro.Modelo = Console.ReadLine();
            Console.Write("Informe o ano do carro: ");
            novoCarro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCarro cadastrado com sucesso!");
            novoCarro.ExibirInformacoes();
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }


        public decimal ValorEmEstoque
        {
            get { return Preco * Quantidade; }
        }

        public void AdicionarAoEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverDoEstoque(int quantidade)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade a ser removida é maior do que a presente no estoque!");
            }
        }
    }

    class EstoqueProduto
    {
        public void demonstrarEstoque()
        {
            Produto produto1 = new Produto { Nome = "Caderno", Preco = 10.50m, Quantidade = 50 };
            Produto produto2 = new Produto { Nome = "Caneta", Preco = 2.00m, Quantidade = 100 };

            Console.WriteLine($"Valor total em estoque do produto {produto1.Nome}: R${produto1.ValorEmEstoque}");

            produto1.AdicionarAoEstoque(20);
            Console.WriteLine($"Nova quantidade em estoque de {produto1.Nome}: {produto1.Quantidade}");

            produto2.RemoverDoEstoque(120);
            Console.WriteLine($"Quantidade em estoque de {produto2.Nome}: {produto2.Quantidade}");
        }
    }
}



