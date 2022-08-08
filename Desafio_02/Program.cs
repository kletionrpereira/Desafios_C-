using System;

namespace Desafio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string nome1 = "Felipe Silva";
                int idade1 = 34;
                double peso1 = 66.4;
                double altura1 = 1.7;
                bool EhDev1 = true;

                string nome2 = "Joao Santos";
                int idade2 = 82;
                double peso2 = 89;
                double altura2 = 1.76;
                bool EhDev2 = true;

                string nome3 = "Gustavo Silva";
                int idade3 = 56;
                double peso3 = 78.4;
                double altura3 = 1.56;
                bool EhDev3 = false;

                string nome4 = "Maria Silva";
                int idade4 = 23;
                double peso4 = 67.4;
                double altura4 = 1.98;
                bool EhDev4 = false;

                string nome5 = "Alessandra Rodrigues";
                int idade5 = 76;
                double peso5 = 67.4;
                double altura5 = 1.45;
                bool EhDev5 = true;

                // T1 - Somar a idade de todos Ubuntus
                int idadeTotal = idade1 + idade2 + idade3 + idade4 + idade5;
                Console.WriteLine($"T1 - A soma da idade dos ubuntos é: {idadeTotal}");
                Console.WriteLine();

                // T2 - Agrupar o nome de todos Ubuntus
                string gropoNomes = nome1 + ", " + nome2 + ", " + nome3 + ", " + nome4 + " e " + nome5;
                Console.WriteLine($"os nomes são: {gropoNomes}"); 
                Console.WriteLine("\n");


                // T3 - Calcular a média IMC dos Ubuntus
                double imc1 = peso1 / (altura1 * altura1);
                double imc2 = peso2 / (altura2 * altura2);
                double imc3 = peso3 / (altura3 * altura3);
                double imc4 = peso4 / (altura4 * altura4);
                double imc5 = peso5 / (altura5 * altura5);
            double mediaTodos = (imc1 + imc2 + imc3 + imc4 + imc5) / 5;
                Console.WriteLine($"T3 - Médias IMC dos Ubuntus são: {mediaTodos.ToString("F2")}");
                Console.WriteLine();

                // T4 - Contar quantos Ubuntus são Devs

                Console.WriteLine("T4 - Os seguintes Ubuntus são Devs:");

                if (EhDev1 == true)
                {
                    Console.WriteLine("Felipe Silva");
                }
                else
                {
                    Console.WriteLine();
                }

                if (EhDev2 == true)
                {
                    Console.WriteLine("Joao Santos");
                }
                else
                {
                    Console.WriteLine();
                }

                if (EhDev3 == true)
                {
                    Console.WriteLine("Alessandra Rodrigues"); ;
                }
                else
                {
                    Console.WriteLine();
                }


                string ubuntoSilva = null;
                string word = "Silva";

                if (nome1.Contains(word))
                    ubuntoSilva += nome1 + " e ";
                if (nome2.Contains(word))
                    ubuntoSilva += nome3 + " e ";
                if (nome3.Contains(word))
                    ubuntoSilva += nome4;
                 Console.WriteLine($"Os nome que tem Silva no nome são: {ubuntoSilva}");


        }
    }
}
