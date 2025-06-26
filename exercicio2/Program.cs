using System;
using System.Collections.Generic;
using System.Linq;
using produto;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            produto.produto Produto = new produto.produto();
            bool v = true;
            while (v)
            {

                Console.WriteLine("Digite o numero de uma das opções abaixo: ");
                Console.WriteLine("1- Cadastrar um produto");
                Console.WriteLine("2- Remover um produto");
                Console.WriteLine("3- Pesquisar um produto");
                Console.WriteLine("4- Encontrar produto com o menor valor");
                Console.WriteLine("5- Sair");

                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Produto.CadProduto();
                        break;
                    case 2:
                        Produto.RemProduto();
                        break;
                    case 3:
                        Produto.PesProduto();
                        break;
                    case 4:
                        Produto.ProdMenorValor();
                        break;
                    case 5:
                        v = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida, tente novamente.");
                        break;
                }


                Console.WriteLine("Pressione qualquer tecla para voltar ao código");
                Console.ReadKey();

                Console.Clear();
            }

        }
    }
}