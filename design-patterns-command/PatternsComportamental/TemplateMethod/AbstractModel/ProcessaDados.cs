using DesignPatters.PatternsComportamental.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.TemplateMethod.AbstractModel
{
    public abstract class ProcessaDados
    {
        protected List<Pessoa> pessoas;
        protected string json;
        protected string xml;

        public ProcessaDados()
        {

        }

        protected ProcessaDados(string xml = "", string json = "")
        {
            if (!string.IsNullOrEmpty(xml))
            {
                this.xml = xml;   
            }
            else if (!string.IsNullOrEmpty(json))
            {
                this.json = json;
            }
            this.pessoas = new List<Pessoa>();

        }

        public virtual void ProcessarXml() { }
        public virtual void ProcessarJson() { }

        protected void ApresentarValores()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(new string('#', 40));
                Console.WriteLine($"Cliente: {pessoa.Nome}\n");

                double valorTotal = 0;

                foreach (var acao in pessoa.Acoes)
                {
                    Console.WriteLine(new string('-', 30));
                    valorTotal += acao.ValorUnitario * acao.Quantidade;
                    Console.WriteLine($"Sigla: {acao.Sigla}\nValor Unitário: {acao.ValorUnitario.ToString("C")} \nQuantidade: {acao.Quantidade}  \nValor total: {valorTotal.ToString("C")}");
                }

            }

        }
    }
}
