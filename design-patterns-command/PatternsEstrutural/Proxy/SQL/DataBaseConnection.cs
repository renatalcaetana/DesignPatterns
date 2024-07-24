using DesignPatters.PatternsEstrutural.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Proxy.SQL
{
    public class DataBaseConnection
    {
        public void RegistrarAcessoVPN(User user)
        {
            var query = $"INSERT INTO TB_RegristroVPN (User, Passoword, DataHora)\nVALUES" +
                $"('{user.Username}', '{user.Password}', {DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")})\n";

            Console.WriteLine($"[!] - Registrando acesso pelo proxy...\n");
            Console.WriteLine(query);

        }
    }
}
