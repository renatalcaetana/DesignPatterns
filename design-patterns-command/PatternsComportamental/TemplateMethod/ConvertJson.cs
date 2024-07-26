using DesignPatters.PatternsComportamental.TemplateMethod.AbstractModel;
using DesignPatters.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.TemplateMethod
{
    public class ConvertJson: ProcessaDados
    {
        public ConvertJson(string json): base(json: json)
        {
        }
        public override void ProcessarJson() 
        {
            this.pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(this.json);

            this.ApresentarValores();
        }
    }
}
