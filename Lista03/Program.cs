using System;

namespace Lista03;

class Program
{
    static void Main(string[] args)
    {
        Lista1 lista1 = new Lista1();
        Lista2 lista2 = new Lista2();
        Lista3 lista3 = new Lista3();
        Lista4 lista4 = new Lista4();
        Lista5 lista5 = new Lista5();
        Lista6 lista6 = new Lista6();
        HashSet1 hashSet1 = new HashSet1();
        HashSet2 hashSet2 = new HashSet2();
        HashSet3 hashSet3 = new HashSet3();
        HashSet4 hashSet4 = new HashSet4();
        Dicionario1 dicionario1 = new Dicionario1();
        
        int opc;
        do
        {
            Console.WriteLine("\n--- LISTA 03 ----");
            Console.WriteLine("1. Lista");
            Console.WriteLine("2. Hash Set");
            Console.WriteLine("3. Dictionary");
            Console.WriteLine("0. Sair");
            Console.WriteLine("\n Insira a opção desejada: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc) 
            {
                case 1:
                    int opc1;
                    do
                    {
                        Console.WriteLine("\n--- LISTA ---");
                        Console.WriteLine("1. Números inteiros");
                        Console.WriteLine("2. Somando elementos de uma lista");
                        Console.WriteLine("3. Filtrando elementos com condição");
                        Console.WriteLine("4. Encontrando o maior e menor valor");
                        Console.WriteLine("5. Removendo duplicatas de uma lista");
                        Console.WriteLine("6. Invertendo uma lista");
                        Console.WriteLine("0. Voltar");
                        Console.WriteLine("\n Insira a opção desejada: ");
                        opc1 = int.Parse(Console.ReadLine());

                        switch (opc1)
                        {

                            case 1:
                                lista1.caso1();
                                break;

                            case 2:
                                lista2.caso2();
                                break;

                            case 3:
                                lista3.caso3();
                                break;

                            case 4:
                                lista4.caso4();
                                break;

                            case 5:
                                lista5.caso5();
                                break;

                            case 6:
                                lista6.caso6();
                                break;

                            
                        }


                    } while (opc1 != 0);


                    break;
                    
                case 2:
                    int opc2;
                    do
                    {
                        Console.WriteLine("\n--- HASH SET ---");
                        Console.WriteLine("1. Criando um conjunto de palavras únicas");
                        Console.WriteLine("2. União de conjuntos");
                        Console.WriteLine("3. Interseção de conjuntos");
                        Console.WriteLine("4. Diferença entre conjuntos");
                        Console.WriteLine("0. Voltar");
                        Console.WriteLine("\n Insira a opção desejada: ");
                        opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {

                            case 1:
                                hashSet1.caso1();
                                break;

                            case 2:
                                hashSet2.caso2();
                                break;

                            case 3:
                                hashSet3.caso3();
                                break;

                            case 4:
                                hashSet4.caso4();
                                break;

                            
                        }


                    } while (opc2 != 0);


                    break;

                case 3:
                    dicionario1.caso1();

                    break;

                case 0:
                    Console.WriteLine("\nSaindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;

            }
         




        } while (opc != 0);
    }
}