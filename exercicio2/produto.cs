using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace produto
{
    public class produto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public static List<produto> Produto = new List<produto>();

        public void CadProduto()
        {
            produto nvproduto = new produto();
            Console.WriteLine("Cadastrar um produto");
            Console.WriteLine("Escreva a descrição do seu produto: ");
            nvproduto.Descricao = Console.ReadLine();
            Console.WriteLine("Escreva o valor do seu produto: ");
            nvproduto.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto.Add(nvproduto);
            Console.WriteLine("Produto cadastrado!");
        }
        public void RemProduto()
        {
            Console.WriteLine("Digite a descrição do produto que deseja remover: ");
            string desc = Console.ReadLine();
            produto prodEncontrado = Produto.FirstOrDefault(a => a.Descricao == desc);

            if (prodEncontrado != null)
            {
                Produto.Remove(prodEncontrado);
                Console.WriteLine("Produto removido");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void PesProduto()
        {
            Console.WriteLine("Digite a descrição do produto que deseja pesquisar: ");
            string desc = Console.ReadLine();
            produto prodEncontrado = Produto.FirstOrDefault(a => a.Descricao == desc);

            if (prodEncontrado != null)
            {
                Console.WriteLine("\n---- DETALHES DO PRODUTO: ----");
                Console.WriteLine($"Descrição do produto: {prodEncontrado.Descricao} \nValor: R${prodEncontrado.Valor:F2}");

            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void ProdMenorValor()
        {
            double menorValor = double.MaxValue;
            produto produtoMenor = null;
            for (int i = 0; i < Produto.Count; i++)
            {
                if (Produto[i].Valor < menorValor)
                {
                    menorValor = Produto[i].Valor;
                    produtoMenor = Produto[i];
                }
            }
            if (produtoMenor != null)
            {
                Console.WriteLine($"Produto com o menor valor: {produtoMenor.Descricao}");
                Console.WriteLine($"Valor: R${produtoMenor.Valor:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado.");
            }

        }
    }
}