using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.TemplateMethod
{
    public class Client
    {
        public void ConsumirEndpointXml()
        {
            Console.WriteLine("\n________________XML__________________\n");

            var xml = ObterDadosAPI.EndPointXml();
            ConvertXml convertXml = new ConvertXml(xml);

            convertXml.ProcessarXml();
        }
        public void ConsumirEndpointJson()
        {
            Console.WriteLine("\n________________JSON__________________\n");

            var json = ObterDadosAPI.EndpointJson();
            ConvertJson convertXml = new ConvertJson(json);

            convertXml.ProcessarJson();
        }

    }
}
