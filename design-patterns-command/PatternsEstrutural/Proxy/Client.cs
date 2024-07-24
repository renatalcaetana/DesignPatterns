using DesignPatters.PatternsEstrutural.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Proxy
{
    public class Client
    {
        public void TentativaConexaoClientVPN()
        {
            VPNProxy proxy = new VPNProxy();
            Console.WriteLine("Digite o username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Digite a senha: ");
            string password = Console.ReadLine();

            var user = new User(username, password);

            proxy.AcessarVpn(user);

        }
    }
}
