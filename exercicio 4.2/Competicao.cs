using System;
using System.Collections.Generic;
using GerenciadorCompeticoes;

namespace Competicao
{
    public class Competicaoo
    {
        public string Nome { get; private set; }
        private List<Competidor> competidores;
        public IReadOnlyList<Competidor> Competidores => competidores.AsReadOnly();

        public Competicaoo(string nome)
        {
            Nome = nome;
            competidores = new List<Competidor>();
        }
        public void AdicionarCompetidor(Competidor c)
        {
            if (c == null)
                throw new ArgumentNullException(nameof(c));

            competidores.Add(c);
        }
    }
}
