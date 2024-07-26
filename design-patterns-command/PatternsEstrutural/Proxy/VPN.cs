using DesignPatters.PatternsEstrutural.Proxy.Interface;
using DesignPatters.PatternsEstrutural.Proxy.Model;

namespace DesignPatters.PatternsEstrutural.Proxy
{
    public class VPN : IProxy
    {
        public void AcessarVpn(User user)
        {
            Console.WriteLine("[+] - Acessando VPN\n");
            Thread.Sleep(2000);
            Console.WriteLine($"{user.Username}, você está logado na vpn");
        }
    }
}
