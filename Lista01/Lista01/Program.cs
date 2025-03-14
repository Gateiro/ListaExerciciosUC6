using Lista01;
using System;

namespace ListaDeExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            EstruturaBasica estruturaBasica = new EstruturaBasica();
            VariaveisETiposDeDados variaveis = new VariaveisETiposDeDados();
            EstruturasCondicionais estruturasCondicionais = new EstruturasCondicionais();
            EstruturasDeRepeticao estruturasDeRepeticao = new EstruturasDeRepeticao();
            ArraysEColecoes arraysEColecoes = new ArraysEColecoes();
            CadastroCarro cadastroCarro = new CadastroCarro();
            EstoqueProduto estoqueProduto = new EstoqueProduto();
            Exibir exibir = new Exibir();
            ExibirAluno exibirAluno = new ExibirAluno();
            NovaConta novaConta = new NovaConta();


            do
            {
                Console.WriteLine("---- MENU DE EXERCÍCIOS ----");
                Console.WriteLine("\n1. Estrutura Básica");
                Console.WriteLine("2. Variáveis e tipos de dados");
                Console.WriteLine("3.Estruturas Condicionais");
                Console.WriteLine("4. Estrutura de repetição");
                Console.WriteLine("5. Arrays e coleções");
                Console.WriteLine("6. Programação Orientada a Objetos");
                Console.WriteLine("7. Herança e Polimorfismo");
                Console.WriteLine("8. Encapsulamento");
                Console.WriteLine("0. Sair");
                Console.Write("\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int opc1;
                        do
                        {
                            Console.WriteLine("\n---- ESTRUTURA BÁSICA ----");
                            Console.WriteLine("\n1. Olá mundo");
                            Console.WriteLine("2. Escreva seu nome");
                            Console.WriteLine("3. Números inteiros");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc1 = int.Parse(Console.ReadLine());
                            switch (opc1)
                            {
                                case 1:
                                    estruturaBasica.OlaMundo();
                                    break;

                                case 2:
                                    estruturaBasica.SeuNome();
                                    break;

                                case 3:
                                    estruturaBasica.NumerosInteiros();
                                    break;

                            }
                        } while (opc1 != 0);

                        break;

                    case 2:
                        int opc2;
                        do
                        {
                            Console.WriteLine("\n---- VARIÁVEIS E TIPOS DE DADOS ----");
                            Console.WriteLine("\n1. Variáveis e tipos de dados");
                            Console.WriteLine("2. Conversor Celsius para Fahrenheit");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc2 = int.Parse(Console.ReadLine());
                            switch (opc2)
                            {
                                case 1:
                                    variaveis.VariaveisDados();
                                    break;

                                case 2:
                                    variaveis.ConversorCelsiusFahrenheit();
                                    break;

                            }
                        } while (opc2 != 0);

                        break;

                    case 3:
                        int opc3;
                        do
                        {
                            Console.WriteLine("\n---- ESTRUTURAS CONDICIONAIS ----");
                            Console.WriteLine("\n1. Verificar par ou impar");
                            Console.WriteLine("2. O maior de três números");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc3 = int.Parse(Console.ReadLine());
                            switch (opc3)
                            {
                                case 1:
                                    estruturasCondicionais.parOuImpar();
                                    break;

                                case 2:
                                    estruturasCondicionais.maiorDeTres();
                                    break;

                            }
                        } while (opc3 != 0);

                        break;

                    case 4:
                        int opc4;
                        do
                        {
                            Console.WriteLine("\n---- ESTRUTURA DE REPETIÇÃO ----");
                            Console.WriteLine("\n1. Contador de 0 à 100");
                            Console.WriteLine("2. A sua tabuada!");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc4 = int.Parse(Console.ReadLine());
                            switch (opc4)
                            {
                                case 1:
                                    estruturasDeRepeticao.deZeroACem();
                                    break;

                                case 2:
                                    estruturasDeRepeticao.tabuada();
                                    break;

                            }
                        } while (opc4 != 0);

                        break;

                    case 5:
                        int opc5;
                        do
                        {
                            Console.WriteLine("\n---- ARRAYS E COLEÇÕES ----");
                            Console.WriteLine("\n1. Números em uma Array");
                            Console.WriteLine("2. Cinco nomes de alunos");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc5 = int.Parse(Console.ReadLine());
                            switch (opc5)
                            {
                                case 1:
                                    arraysEColecoes.cincoNumeros();
                                    break;

                                case 2:
                                    arraysEColecoes.nomesAlunos();
                                    break;

                            }
                        } while (opc5 != 0);

                        break;

                    case 6:
                        int opc6;
                        do
                        {
                            Console.WriteLine("\n---- PROGRAMAÇÃO ORIENTADA A OBJETOS ----");
                            Console.WriteLine("\n1. Cadastro de novo carro");
                            Console.WriteLine("2. Demonstração de estoque de produto");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc6 = int.Parse(Console.ReadLine());
                            switch (opc6)
                            {
                                case 1:
                                    cadastroCarro.cadastroCarro();
                                    break;

                                case 2:
                                    estoqueProduto.demonstrarEstoque();
                                    break;

                            }
                        } while (opc6 != 0);

                        break;

                    case 7:
                        int opc7;
                        do
                        {
                            Console.WriteLine("\n---- HERANÇA E POLIMORFISMO ----");
                            Console.WriteLine("\n1. Animais: Som e movimento");
                            Console.WriteLine("2. Pessoa");
                            Console.WriteLine("0. Menu Principal");
                            Console.WriteLine("\nDigite o exercício desejado: ");
                            opc7 = int.Parse(Console.ReadLine());
                            switch (opc7)
                            {
                                case 1:
                                    exibir.exibirCachorroGato();
                                    break;

                                case 2:
                                    exibirAluno.exibirAluno();
                                    break;

                            }
                        } while (opc7 != 0);

                        break;

                    case 8:
                        Console.WriteLine("\n---- ENCAPSULAMENTO ----");
                        Console.WriteLine("\n1. Exemplo Conta Bancária ");
                        novaConta.testeConta(); 
                        break;

                    case 0:
                                Console.WriteLine("Saindo...");
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                            }

                        } while (opcao != 0);          

                }
            }
}