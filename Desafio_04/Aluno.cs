﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_04
{
    public class Aluno

    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }


        public Aluno(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }

        public Aluno()
        {
        }
    }


}
