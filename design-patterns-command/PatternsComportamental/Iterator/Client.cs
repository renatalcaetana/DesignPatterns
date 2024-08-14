using DesignPatters.PatternsComportamental.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatters.PatternsComportamental.Iterator
{
    public class Client
    {
        public void ConsumirEstruturaDados()
        {
            Aggregate aggregate = new Aggregate();

            aggregate[0] = "Item 01";
            aggregate[1] = "Item 02";
            aggregate[2] = "Item 03";

            IIterator iterator = aggregate.GetIterator();

            for (string item = iterator.Next; iterator.HasNext; item = iterator.Next)
            {
                Console.WriteLine(item);
            }

        }
    }
}
