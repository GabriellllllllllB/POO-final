using System;
using System.Collections.Generic;
using System.Linq;

namespace interfacePagamentos
{
    public interface IPagamentos
    {
        void ProcessarPagamento(double valor);
    }
}