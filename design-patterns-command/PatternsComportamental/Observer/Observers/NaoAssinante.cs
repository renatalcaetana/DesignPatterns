using DesignPatters.PatternsComportamental.Observer.Interfaces;
using DesignPatters.PatternsComportamental.Observer.Model;

namespace DesignPatters.PatternsComportamental.Observer.Observers
{
    public class NaoAssinante : IObservavel
    {
        public NaoAssinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public Pessoa Pessoa { get; set; }
        public string Mensagem { get; set; }


        public void Update()
        {
            Console.WriteLine($"Enviando email para :{Pessoa.Email}\n");
            Console.WriteLine($"Prezado {Pessoa.Nome}\n{Mensagem}");

            Console.WriteLine($"\n Insert into tb_Notificacao (PessoaId, Notifica, Mes) values {Pessoa.Id}, 1, {DateTime.Now.Month})\n");
        }
    }
}
