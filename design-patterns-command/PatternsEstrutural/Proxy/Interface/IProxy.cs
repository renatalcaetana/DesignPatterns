using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.PatternsEstrutural.Proxy.Model;

namespace DesignPatters.PatternsEstrutural.Proxy.Interface
{
    public interface IProxy
    {
        void AcessarVpn(User user);
    }
}
