using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinaContasPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            Console.WriteLine("\nProcessando regras de negócio contas a pagar...");
            Thread.Sleep(1000);

            return result;
        }
        public string ExecutarRotinaContasReceber (string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            Console.WriteLine("\nProcessando regras de negócio contas a receber...");
            Thread.Sleep(1000);

            return result;
        }
    }
    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("junho", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("julho", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("agosto", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("setembro", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("outubro", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("junho", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            
            return dic[mes];
        }
        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("junho", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("julho", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("agosto", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("setembro", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("outubro", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");
            dic.Add("junho", "CNPJ:1112222222222\nRazão social: Lojas prudente\nValor:1200.00\nContato:(11) 1233-12222");

            return dic[mes];
        }
    }
}
