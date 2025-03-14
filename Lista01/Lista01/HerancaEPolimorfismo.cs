using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class HerancaEPolimorfismo
    { }
    

class Animal
    {
        public virtual void Falar()
        {
            Console.WriteLine("O animal faz um som.");
        }

        public virtual void Mover()
        {
            Console.WriteLine("O animal está se movendo.");
        }
    }

    class Cachorro : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Au au!");
        }
        public override void Mover()
        {
            Console.WriteLine("O cachorro se moveu!");
        }

    }

     class Gato : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Miau!");
        }
        public override void Mover()
        {
            Console.WriteLine("O gato se moveu!");
        }
    }

    public class Exibir
    {
        public void exibirCachorroGato()
        {
            Animal cachorro = new Cachorro();
            Animal gato = new Gato();

            cachorro.Falar();
            cachorro.Mover();

            gato.Falar();
            gato.Mover();
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }

    class ExibirAluno
    {
        public void exibirAluno()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "João da Silva";
            aluno.Idade = 20;
            aluno.Matricula = 12345;

            aluno.ExibirInformacoes();
        }
    }
}

