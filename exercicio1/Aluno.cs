using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Aluno
    {
        public string RA { get; set; }
        public string NOME { get; set; }
        public int IDADE { get; set; }

        public Aluno(string ra, string nome, int idade)
            {
            RA = ra;
            NOME = nome;
            IDADE = idade;
        }

            
        public void CadastrarAluno(List<Aluno> alunos)
        {
            string ra;
            string nome;
            int idade;

            Console.WriteLine("Digite o RA:");
            ra = Console.ReadLine();
            Console.Write("Digite o Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade:");
            idade = int.Parse(Console.ReadLine());
            Aluno novo = new Aluno(ra, nome, idade);
            alunos.Add(novo);
            Console.WriteLine("Aluno cadastrado.");
        }
        public void ListarAlunos(List<Aluno> alunos)
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Não existe aluno cadastrado.");
            }
            else
            {
                foreach (Aluno aluno in alunos)
                {
                    Console.WriteLine($"RA: {aluno.RA}, Nome: {aluno.NOME}, Idade: {aluno.IDADE}");
                }
            }
        }
        public void AlterarDados(List<Aluno> alunos)
        {
            string ra;
            Console.WriteLine("Digite o RA do aluno que deseja alterar:");
            ra = Console.ReadLine();
            Aluno aluno = alunos.Find(a => a.RA == ra);
            if (aluno == null)
            {
                Console.WriteLine("Aluno não existente.");
                return;
            }
            Console.WriteLine("O que você deseja alterar?");

            Console.WriteLine("1 - RA");
            Console.WriteLine("2 - Nome");
            Console.WriteLine("3 - Idade");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o novo RA:");
                    aluno.RA = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Digite o novo Nome:");
                    aluno.NOME = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Digite a nova Idade:");
                    aluno.IDADE = int.Parse(Console.ReadLine());
                    break;
                default:
                    return;
            }
        }
        public void RemoverAluno(List<Aluno> alunos)
        {
            string ra;
            Console.WriteLine("Digite o RA do aluno que deseja remover:");
            ra = Console.ReadLine();
            Aluno aluno = alunos.Find(a => a.RA == ra);
            if (aluno == null)
            {
                Console.WriteLine("esse aluno não existe.");
                return;
            }
            alunos.Remove(aluno);
            Console.WriteLine("Aluno removido.");

        }
    }
}
