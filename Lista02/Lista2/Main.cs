using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor4 vetor4 = new Vetor4();
            Vetor5 vetor5 = new Vetor5();
            Vetor6 vetor6 = new Vetor6();
            Vetor7 vetor7 = new Vetor7();
            Matriz1 matriz1 = new Matriz1();
            Matriz2 matriz2 = new Matriz2();
            Matriz3 matriz3 = new Matriz3();
            Matriz4 matriz4 = new Matriz4();
            Matriz5 matriz5 = new Matriz5();
            Matriz6 matriz6 = new Matriz6();
            Matriz7 matriz7 = new Matriz7();
            Matriz8 matriz8 = new Matriz8();
            Matriz9 matriz9 = new Matriz9();
            Matriz10 matriz10 = new Matriz10();
            Matriz11 matriz11 = new Matriz11();
            Matriz12 matriz12 = new Matriz12();
            Matriz13 matriz13 = new Matriz13();
            
            int opc;
            do
            {
                Console.WriteLine("---- MENU DE EXERCÍCIOS ----");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("0. Sair");
                Console.WriteLine("Insira a opção desejada: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc) 
                {
                    case 1:
                        int opc1;
                        do
                        {
                            Console.WriteLine("\n---- VETORES ----");
                            Console.WriteLine("1. Soma vetores");
                            Console.WriteLine("2. Média dos valores de um vetor");
                            Console.WriteLine("3. Busca vetor");
                            Console.WriteLine("4. Maior e menor");
                            Console.WriteLine("5. Ordem crescente");
                            Console.WriteLine("6. Separar impar e par");
                            Console.WriteLine("7. Verificar palindromo");
                            Console.WriteLine("0. Voltar");
                            Console.WriteLine("\nInsira a opção desejada: ");
                            opc1 = int.Parse(Console.ReadLine());
                            switch (opc1)
                            {
                                
                                case 1:
                                    int[] numeros = { 1, 2, 3, 4, 5 };
                                    int soma = 0;

                                    for (int i = 0; i < numeros.Length; i++)

                                    {
                                        Console.WriteLine($"O valor na posição {i} é {numeros[i]}\n");
                                        soma += numeros[i];

                                    }
                                    Console.WriteLine($"A soma dos valores totais é: {soma}");
                                    break;

                                case 2:
                                    int media = 0;
                                    int soma2 = 0;
                                    int[] numeros2 = new int[5];
                                    Console.WriteLine("Digite 5 números: \n");

                                    for (int i = 0; i < numeros2.Length; i++)
                                    {
                                        Console.WriteLine($"Digite o {i + 1}º número: \n");
                                        numeros2[i] = int.Parse(Console.ReadLine());
                                        soma2 += numeros2[i];
                                    }
                                    media = soma2 / numeros2.Length;
                                    Console.WriteLine($"A média dos valores digitados é: {media}");
                                    break;

                                case 3:
                                    int contador = 0;
                                    int[] numeros3 = new int[5];
                                    Console.WriteLine("Digite 5 números: \n");

                                    for (int i = 0; i < numeros3.Length; i++)
                                    {
                                        Console.WriteLine($"Digite o {i + 1}º número: \n");
                                        numeros3[i] = int.Parse(Console.ReadLine());
                                    }

                                    Console.WriteLine($"Digite um número para busca: \n");
                                    int busca = int.Parse(Console.ReadLine());

                                    for (int i = 0; i < numeros3.Length; i++)
                                    {
                                        if (numeros3[i] == busca)
                                        {
                                            contador++;
                                        }
                                    }

                                    Console.WriteLine($"O valor procurado apareceu {contador} vezes");

                                    break;

                                case 4:
                                    vetor4.caso4();
                                    break;

                                case 5:
                                    vetor5.caso5();
                                    break;

                                case 6:
                                    vetor6.caso6();
                                    break;

                                case 7:
                                    vetor7.caso7();
                                    break;

                                case 0:
                                    Console.WriteLine("Saindo...");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;

                            }



                        } while (opc1 != 0);

                        break;
                    case 2:
                        int opc2;
                        do
                        {
                            Console.WriteLine("\n---- MATRIZ ----");
                            Console.WriteLine("1. Soma elementos de uma matriz");
                            Console.WriteLine("2. Multiplicar matrizes");
                            Console.WriteLine("3. Matriz identidade");
                            Console.WriteLine("4. Encontrar o maior valor em cada linha");
                            Console.WriteLine("5. Soma das linhas e colunas");
                            Console.WriteLine("6. Matriz transposta");
                            Console.WriteLine("7. Elementos diagonal, principal e secundária");
                            Console.WriteLine("8. Buscar elemento em uma matriz");
                            Console.WriteLine("9. Contar elementos positivos e negativos");
                            Console.WriteLine("10. Substituir valores negativos por zero");
                            Console.WriteLine("11. Multiplicar diagonal principal");
                            Console.WriteLine("12. Calcular a soma das bordas");
                            Console.WriteLine("13. Contar números pares e ímpares em uma matriz");
                            Console.WriteLine("0. Voltar");
                            Console.WriteLine("\nInsira a opção desejada: ");
                            opc2 = int.Parse(Console.ReadLine());

                            switch (opc2)
                            {
                                case 1:
                                    matriz1.caso1();
                                break;

                                case 2:
                                    matriz2.caso2();
                                break;

                                case 3:
                                    matriz3.caso3();
                                break;

                                case 4:
                                    matriz4.caso4();
                                break;

                                case 5:
                                    matriz5.caso5();
                                break;

                                case 6:
                                    matriz6.caso6();
                                break;

                                case 7:
                                    matriz7.caso7();
                                break;

                                case 8:
                                    matriz8.caso8();
                                break;

                                case 9:
                                    matriz9.caso9();
                                break;

                                case 10:
                                    matriz10.caso10();
                                break;

                                case 11:
                                    matriz11.caso11();
                                break;

                                case 12:
                                    matriz12.caso12();
                                break;

                                case 13:
                                    matriz13.caso13();
                                break;

                            }




                        } while (opc2 != 0);    
                         break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opc != 0);


        }

    }
}
