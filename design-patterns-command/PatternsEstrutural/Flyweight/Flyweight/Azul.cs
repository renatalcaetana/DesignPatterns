using DesignPatters.PatternsEstrutural.Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Flyweight.Flyweight
{
    public class Azul : EspacoNave
    {
        public Azul()
        {
            this.condicao = "voando em linha reta - ";
            this.acao = "disparando laser";
        }
        public override void Exibir(string cor, string tamanho)
        {
            this.cor = cor;
            this.tamanho = tamanho;
            Console.WriteLine($"Nave {this.tamanho} e {this.cor} {this.condicao} {this.acao}");
        }
    }
}
