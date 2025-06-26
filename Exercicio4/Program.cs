using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1- Dividir dois números");
                Console.WriteLine("2- Sair do programa");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:


                        try
                        {
                            Console.WriteLine("Digite o primeiro número: ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo número: ");
                            int num2 = int.Parse(Console.ReadLine());

                            int res = num1 / num2;
                            Console.WriteLine($"Resultado: {res}");

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Valor inválido. Digite um número inteiro.");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro inesperado: {ex.Message}");
                        }
                        break;
                    case 2:
                        executando = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao programa");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
