﻿namespace SistemaAcademico.Dominio;

public class Aluno
{
    public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Nota { get; set; }

        public Aluno(string nome, decimal nota)
        {
            Nome = nome;
            Nota = nota;
        }
        public bool EstaAprovado()
        {
            return Nota >=7
        }
}
