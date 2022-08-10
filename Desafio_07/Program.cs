using System;
using System.Collections.Generic;

namespace Desafio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Popular Base");
                Console.WriteLine("2 - Cadastrar usuário");

                string resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "1":

                        List<Status> status = new List<Status>() {
                            new Status(EStatus.Andamento),
                            new Status(EStatus.Concluido),
                            new Status(EStatus.Fechado)
                        };

                        foreach (var item in status)
                            item.Salvar();

                        List<Cursos> cursos = new List<Cursos>() {
                            new Cursos("Administração", 0),
                            new Cursos("Ciência da computação", 1),
                            new Cursos("Arquitetura", 2)
                        };

                        foreach (var item in cursos)
                            item.Salvar();

                        Console.WriteLine("Cadastro com sucesso!");

                        break;

                    case "2":
                        var aluno = new Alunos();

                        Console.WriteLine("\nDigite o nome do Aluno: ");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("\nDigite a idade do Aluno: ");
                        aluno.Idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nDigite a nota do Aluno: ");
                        aluno.Nota = Decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                        Console.WriteLine("\nDigite o curso do Aluno.\n(0 = Administração; 1 = Ciência da computação; 2 = Arquitetura)");
                        aluno.CursoId = Convert.ToInt32(Console.ReadLine());

                        aluno.Salvar();
                        Console.WriteLine("Cadastro com sucesso!");

                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Digite 'parar' para sair");
            } while (Console.ReadLine() != "parar");
        }
    }
}
