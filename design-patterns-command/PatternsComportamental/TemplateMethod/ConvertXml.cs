using DesignPatters.PatternsComportamental.TemplateMethod.AbstractModel;
using DesignPatters.PatternsComportamental.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatters.PatternsComportamental.TemplateMethod
{
    public class ConvertXml: ProcessaDados  
    {
        public ConvertXml(string xml): base(xml: xml)
        {
                
        }

        public override void ProcessarXml()
        {
           XmlSerializer serializer = new XmlSerializer(this.pessoas.GetType());

            var stringReader = new StringReader(this.xml);

            using (var reader = XmlReader.Create(stringReader))
            {
                this.pessoas = (List<Pessoa>)serializer.Deserialize(reader);

            }

            this.ApresentarValores();
        }
    }
}
