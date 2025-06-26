using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using exercicio1;

public class program
{
    static List<Aluno> alunos = new List<Aluno>();
    static void Main()
    {
        Aluno aluno = new Aluno("", "", 0);
        int x = 0;

        do
        {
            Console.WriteLine("Qual opção você deseja fazer?");
            Console.WriteLine("1- cadastrar um aluno");
            Console.WriteLine("2- listar alunos cadastrados");
            Console.WriteLine("3- alterar dados de um aluno existente (localizado pelo RA)");
            Console.WriteLine("4- remover um aluno pelo RA");
            Console.WriteLine("5- encerrar o programa");
            Console.WriteLine("Opção:");
            x = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (x)
            {
                case 1:
                    aluno.CadastrarAluno(alunos);
                    break;
                case 2:
                    aluno.ListarAlunos(alunos);
                    break;
                case 3:
                    aluno.AlterarDados(alunos);
                    break;
                case 4:
                    aluno.RemoverAluno(alunos);
                    break;
                case 5:
                    Console.WriteLine("Programa encerrado");
                    break;
            }
        } while (x != 5);
    }
}








