using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Solid.Model
{
    public class Fogao : Product
    {
        public Fogao(string name, decimal price) : base(name, price)
        {

        }

        public override void AplicarDesconto()
        {
            Price *= .75m;
        }

        public override string ObterCaracteristica()
        {
            return "Fogão";
        }
    }
}
