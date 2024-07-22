using DesignPatters.PatternsEstrutural.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Composite
{
    public class ProductComposite : ComponentModel
    {
        private List<ComponentModel> _components;

        public ProductComposite()
        {
                _components = new List<ComponentModel>();
        }
        public override void Add(params ComponentModel[] components)
        {
            _components.AddRange(components);
        }
        public override ComponentModel? GetChild(int index)
        {
            if (_components.Count == 0)
            {
                Console.WriteLine("Não posssui produtos cadastrados.");
                return null;
            }
            return _components[index];
        }

        public override double Operation()
        {
            double valorTotal = 0;

            for (int i = 0; i < _components.Count; i++)
            {
                var component = _components[i];
                valorTotal += component.Operation();
            }
            return valorTotal;
        }

        public override void Remove(ComponentModel components)
        {
            _components.Remove(components);
        }
    }
}
