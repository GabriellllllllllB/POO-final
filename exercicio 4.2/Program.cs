using System;
using System.Collections.Generic;
using GerenciadorCompeticoes;
using Competicao;
class Program
{
    static void Main(string[] args)
    {
        Competicaoo competicao = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Cadastrar competição");
            Console.WriteLine("2. Adicionar competidor");
            Console.WriteLine("3. Listar competidores");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string opc = Console.ReadLine();
            Console.WriteLine();

            switch (opc)
            {
                case "1":
                    Console.Write("Digite o nome da competição: ");
                    string nomeComp = Console.ReadLine();
                    competicao = new Competicaoo(nomeComp);
                    Console.WriteLine($"Competição {competicao.Nome} cadastrada com sucesso!");
                    break;

                case "2":
                    if (competicao == null)
                    {
                        Console.WriteLine("Cadastre uma competição antes de adicionar competidores.");
                        break;
                    }

                    Console.Write("Nome do competidor: ");
                    string nome = Console.ReadLine();

                    int idade;
                    while (true)
                    {
                        Console.Write("Idade do competidor: ");
                        if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                            break;
                        Console.WriteLine("Idade inválida.");
                    }

                    Console.Write("Modalidade: ");
                    string modalidade = Console.ReadLine();

                    var compet = new Competidor(nome, idade, modalidade);
                    competicao.AdicionarCompetidor(compet);
                    Console.WriteLine("Competidor adicionado com sucesso!");
                    break;

                case "3":
                    if (competicao == null)
                    {
                        Console.WriteLine("Nenhuma competição cadastrada.");
                    }
                    else if (competicao.Competidores.Count == 0)
                    {
                        Console.WriteLine($"Competição {competicao.Nome} não possui competidores.");
                    }
                    else
                    {
                        Console.WriteLine($"Competidores da competição {competicao.Nome}:");
                        foreach (var c in competicao.Competidores)
                        {
                            Console.WriteLine("- " + c);
                        }
                    }
                    Console.WriteLine();
                    Console.Write("Pressione alguma tecla para voltar ao codigo");
                    Console.ReadLine(); 
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
