﻿namespace SCA_PB_2
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }
    }
}