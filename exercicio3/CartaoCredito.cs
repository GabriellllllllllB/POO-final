using interfacePagamentos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CartaoCreditoo
{
    public class CartaoCredito : IPagamentos
    {
        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento no valor R${valor:F2} pagado pelo cartão de crédito.");
        }
        public override string ToString()
        {
            return "Cartão de Crédito";
        }

    }
}