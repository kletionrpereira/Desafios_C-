using Jitbit.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Desafio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int ALUNOS_QTD = 3;

            Console.WriteLine("Soma Notas\n==========\n\n");
            Aluno[] alunos = new Aluno[ALUNOS_QTD];

            for (int i = 0; i < ALUNOS_QTD; i++)
            {
                Console.WriteLine("Qual o nome do aluno {0}:", i + 1);
                string nome = Console.ReadLine();
                Console.WriteLine("Qual a idade do aluno {0}:", i + 1);
                string idade = Console.ReadLine();
                Console.WriteLine("Qual a nota do aluno número {0}:", i + 1);
                string nota = Console.ReadLine();

                alunos[i] = new Aluno();
                alunos[i].Nome = nome;
                alunos[i].Idade = int.Parse(idade);
                alunos[i].Nota = double.Parse(nota);
            }

            double soma = 0;

            foreach (var al in alunos)
            {
                soma += al.Nota;
            }

            Console.WriteLine("Soma das notas: {0}\n", soma);

            //Console.WriteLine("Buscar Aluno");
            //var aluno = Aluno.GetAluno();
            //StringBuilder sb = new StringBuilder();
            //Console.WriteLine("Montando Arquivo");
            //sb.AppendLine("Nome;Idade;Nota");
            //Aluno.GetAluno(x => sb.AppendLine($"{x.Nome};{x.Idade};{x.Nota}"));
            //var filePath = @"E:\Projetos\Qodeless\desafio_05\Arquivo_csv\Aluno.csv";
            //Console.WriteLine("Salvando Arquivo");
            //File.WriteAllText(filePath, sb.ToString());
            //Console.ReadKey();

            List<Aluno> listDeAlunos = new List<Aluno>();
            listDeAlunos.Add(new Aluno() { Nome = "Kleiton", Nota = 9, Idade = 28});
            listDeAlunos.Add(new Aluno() { Nome = "Rafael", Nota = 7, Idade = 18});
            listDeAlunos.Add(new Aluno() { Nome = "Maria", Nota = 8, Idade = 39});


            CsvExport myExsport = new CsvExport();

            foreach(var al in listDeAlunos)
            {
                myExsport.AddRow();
                myExsport["Nome"] = al.Nome;
                myExsport["Nota"] = al.Nota;
                myExsport["Idade"] = al.Idade;

            }
            myExsport.ExportToFile("../../../Desafio_05.csv");

        }
    }
}
