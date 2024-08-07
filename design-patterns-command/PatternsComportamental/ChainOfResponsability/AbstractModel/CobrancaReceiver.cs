using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.ChainOfResponsability.AbstractModel
{
    public abstract class CobrancaReceiver
    {
        public CobrancaReceiver Next = null;

        public CobrancaReceiver AddNext(CobrancaReceiver next)
        { 
            this.Next = next; 
            return this;
        }

        public virtual Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            if (this.Next != null)
            {
                return this.Next.ExecutarCobrancaServico(checkout);
            }
            return null;
        }
    }
}
