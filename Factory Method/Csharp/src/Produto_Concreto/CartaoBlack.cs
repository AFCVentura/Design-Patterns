using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Csharp.src.Produto;

namespace Csharp.src.Produto_Concreto
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoBlack(int limiteCredito, int cobrancaAnual)
        {
            _tipoCartao = "Black";
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao 
        { 
            get { return _tipoCartao; }
        }

        public override int LimiteCredito 
        {
            get { return _limiteCredito;}
            set { _limiteCredito = value;}
        }

        public override int CobrancaAnual 
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}