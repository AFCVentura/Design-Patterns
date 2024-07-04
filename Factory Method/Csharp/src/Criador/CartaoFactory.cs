using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Csharp.src.Produto;

namespace Csharp.src.Criador
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito(); 
    }
}