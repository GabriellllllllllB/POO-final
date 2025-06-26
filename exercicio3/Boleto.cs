using interfacePagamentos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boleto
{
    public class PagamentoBoleto : IPagamentos
    {
        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento no valor R${valor:F2} pagado pelo boleto bancário.");
        }
        public override string ToString()
        {
            return "Boleto Bancário";
        }

    }
}