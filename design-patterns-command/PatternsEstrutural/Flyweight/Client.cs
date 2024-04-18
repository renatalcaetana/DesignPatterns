using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Flyweight
{
    public class Client
    {
        List<string> coresTamanhos = new List<string>()
        {
            "azul:pequena", "cinza:Média", "vermalha:grande", "azul:pequena", "cinza:média", "vermelha:grande", "azul:pequena",
            "cinza:média", "vermelha:grande"
        };

        public void ConsumirFlyweights()
        {
            FlyweightFactory factory = new FlyweightFactory();
            foreach (var item in coresTamanhos)
            {
                var cor = item.Split(":")[0];
                var tamanho = item.Split(":")[1];
                var espacoNave = factory.GetEspacoNave(cor);
                espacoNave.Exibir(cor, tamanho);
                
            }
        }
    }
}
