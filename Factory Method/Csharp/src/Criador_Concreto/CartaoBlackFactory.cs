using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Csharp.src.Criador;
using Csharp.src.Produto;

namespace Csharp.src.Criador_Concreto
{
    public class CartaoBlackFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoBlackFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            throw new NotImplementedException();
        }
    }
}