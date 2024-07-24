using DesignPatters.PatternsEstrutural.Proxy.Interface;
using DesignPatters.PatternsEstrutural.Proxy.Model;
using DesignPatters.PatternsEstrutural.Proxy.SQL;

namespace DesignPatters.PatternsEstrutural.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVpn(User user)
        {
            DataBaseConnection sql = new DataBaseConnection();
            sql.RegistrarAcessoVPN(user);

            Console.WriteLine(new string('-', 40));
            VPN vpn = new VPN();
            vpn.AcessarVpn(user);
        }
    }
}
