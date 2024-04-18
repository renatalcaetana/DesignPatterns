using DesignPatters.PatternsEstrutural.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Adapter
{
    public class cloudComputing
    {
        IAdapter adapter;

        public cloudComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("Processando camada cloud computing contas a pagar");
            Thread.Sleep(3000);

            Console.WriteLine(new String('-', 40));

            result = this.adapter.ExecutarRotinaContasReceber(mes);
            Console.WriteLine("Processando camada cloud computing contas a receber");
            Thread.Sleep(3000);


            Console.WriteLine("\nProcesso finalizado com sucesso!");

        }


    }
}
