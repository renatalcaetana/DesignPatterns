using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Mediator
{
    public class Chat
    {
        public void Conversar()
        {
            MediadorConcreto mediador = new MediadorConcreto();

            Atendente atendente = new Atendente(mediador);
            Paciente paciente = new Paciente(mediador);

            mediador.Atendente = atendente;
            mediador.Paciente = paciente;

            Console.WriteLine("Chat: ");
            paciente.EnviarMensagem("Por favor, eu gostaria de agendar uma consulta.");
            atendente.EnviarMensagem("Sim, por favor, qual especialidade?");

            paciente.EnviarMensagem("Clinico Geral");
            atendente.EnviarMensagem("Temos vagas para o próxima terça nos horários \n16:30hrs\n16:45hrs\n17:00hs");

            paciente.EnviarMensagem("Pode agendar terça as 16:45");
            atendente.EnviarMensagem("Agendamento concluido com sucesso");

            paciente.EnviarMensagem("Obrigado");
            atendente.EnviarMensagem("Nós que agradecemos!");
            Console.WriteLine(new string('-',40));
        }
    }
}
