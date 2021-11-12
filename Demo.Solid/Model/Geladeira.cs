using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Solid.Model
{
    public  class Geladeira : Product
    {

        public Geladeira(string name, decimal price) : base(name, price)
        {
        }

        public override void AplicarDesconto()
        {
            Price *= .8m;
        }

        public override string ObterCaracteristica()
        {
            return "Geladeira";
        }
    }
}
