using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Iterator.Interfaces
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int index] { set;  get; } 
        public int Limit { get; }
    }
}
