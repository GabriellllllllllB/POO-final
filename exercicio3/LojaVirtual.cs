using interfacePagamentos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Loja
{
    internal class LojaVirtual
    {
        public void Pagamento(IPagamentos met, double valor)
        {
            if (met != null)
            {
                met.ProcessarPagamento(valor);
                Console.WriteLine($"Pagamento realizado pelo meio {met}.");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro");
            }

        }
    }
}