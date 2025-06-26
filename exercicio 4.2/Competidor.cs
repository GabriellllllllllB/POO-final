using System;
using System.Collections.Generic;

namespace GerenciadorCompeticoes
{
    public class Competidor
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Modalidade { get; private set; }

        public Competidor(string nome, int idade, string modalidade)
        {
            Nome = nome;
            Idade = idade;
            Modalidade = modalidade;
        }
        public override string ToString()
        {
            return $"{Nome}, {Idade} anos, Modalidade: {Modalidade}";
        }
    }
}