using DesignPatters.PatternsEstrutural.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Composite
{
    public class Client
    {
        public void EfetuarCompra()
        {
            ComponentModel product01 = new ProductLeaf("Caneca Batman", 25.00);
            ComponentModel product02 = new ProductLeaf("Camiseta Star Wars", 80.00);
            ComponentModel product03 = new ProductLeaf("Chaveiro vingadores", 10.00);

            ComponentModel product04 = new ProductLeaf("Estátua Thanos", 500.00);

            ComponentModel smallbox = new ProductComposite();
            smallbox.Add(product01, product02, product03);

            ComponentModel bigbox = new ProductComposite();
            bigbox.Add(smallbox, product04);

            var valorTotal = bigbox.Operation();

            Console.WriteLine($"\nValor total: {valorTotal.ToString("C")}");
        }
    }
}
