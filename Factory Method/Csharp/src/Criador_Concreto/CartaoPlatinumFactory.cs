using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Csharp.src.Criador;
using Csharp.src.Produto;

namespace Csharp.src.Criador_Concreto
{
    public class CartaoPlatinumFactory : CartaoFactory
    {
        public override CartaoCredito BuscarCartaoCredito()
        {
            throw new NotImplementedException();
        }
    }
}