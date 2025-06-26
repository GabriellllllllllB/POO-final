using Boleto;
using CartaoCreditoo;
using interfacePagamentos;
using Loja;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaVirtual loja = new LojaVirtual();
            IPagamentos metPagamento = null;
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1- Pagar");
                Console.WriteLine("2- Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Hora de finalizar o pagamento!");
                        Console.WriteLine("Digite o valor da compra: ");
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Como deseja realizar o seu pagamento?");
                        Console.WriteLine("1-Cartão de crédito");
                        Console.WriteLine("2-Boleto bancário");

                        int opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                metPagamento = new CartaoCredito();
                                break;

                            case 2:
                                metPagamento = new PagamentoBoleto();
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                        loja.Pagamento(metPagamento, valor);
                        break;
                    case 2:
                        executando = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao codigo");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


