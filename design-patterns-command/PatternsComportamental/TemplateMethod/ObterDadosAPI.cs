using DesignPatters.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatters.PatternsComportamental.TemplateMethod
{
    public class ObterDadosAPI
    {
        public static string EndPointXml()
        {
            List<Pessoa> pessoas = GetPessoa();
            XmlSerializer serializer = new XmlSerializer(pessoas.GetType());

            string xml = string.Empty;

            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, pessoas);
                xml = sw.ToString();
            }

            return xml;
        }

        public static string EndpointJson()
        {
            List<Pessoa> pessoas = GetPessoa();
            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }

        private static List<Pessoa> GetPessoa()
        {
            return new List<Pessoa>
            {
                new Pessoa
                {
                    Nome = "José",
                    CPF = "8898981989",
                    Acoes = new List<Acoes>
                    {
                        new Acoes("AAAAA",50,15.44),
                        new Acoes("BBB$",80,55.44),
                    }
                },
                new Pessoa
                {
                    Nome = "Maria",
                    CPF = "122222222",
                    Acoes = new List<Acoes>
                    {
                        new Acoes("AAAAA",50,15.44),
                        new Acoes("BBB$",80,55.44),
                    }
                }
            };
        }
    }
}
