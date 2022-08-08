using System;

namespace Desafio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a Quantidade de Alunos:");
            int Quantidade = int.Parse(Console.ReadLine());

            string nome = "";
            double nota = 0;
            double maiorNota = 0;
            string alunoComMaiorNota = "";

            for(int i = 0; i < Quantidade; i++) 
            {
                Console.WriteLine("Qual o Nome do Aluno?");
                 nome = Console.ReadLine();

                Console.WriteLine("Qual a Nota do aluno?");
                 nota = double.Parse(Console.ReadLine());

               if(nota > maiorNota)
                {
                    maiorNota = nota;
                    alunoComMaiorNota = nome;
                }
            
            }

            Console.WriteLine("Aluno com maior nota:");
            Console.WriteLine(alunoComMaiorNota);
        }
    }
}
