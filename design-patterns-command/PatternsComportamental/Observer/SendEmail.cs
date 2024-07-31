using DesignPatters.PatternsComportamental.Observer.Interfaces;
using DesignPatters.PatternsComportamental.Observer.Observers;
using DesignPatters.PatternsComportamental.Observer.Subjects;
using System.Globalization;

namespace DesignPatters.PatternsComportamental.Observer
{
    public class SendEmail
    {
        public void EnviarEmail()
        {
            string msgNaoAssinante = $"Notamos que ainda não faz parte da maior e menor plataforma de series e filmes, não fique de fora das promoções de {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} " +
                $"acesse nossa plataforma para ver os mais recentes lançamentos.";

            var msgAssinante = $"Lançamentos para o mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} direto do cinema para sua tela.";

            List<IObservavel> observavels = new List<IObservavel>()
            {
                new NaoAssinante(new Model.Pessoa(01, "José", "jose@gmail.com"), msgNaoAssinante),
                new NaoAssinante(new Model.Pessoa(02, "Maria", "maria@gmail.com"), msgNaoAssinante),
                new Assinante(new Model.Pessoa(03, "Renata", "renata@gmail.com"), msgAssinante),
                new Assinante(new Model.Pessoa(04, "Lorena", "lorena@gmail.com"), msgAssinante),
            };

            var primeVideos = new PrimeVideos();

            foreach (var observavel in observavels)
            {
                primeVideos.AddObservavel(observavel);
            }
            primeVideos.NoficarObservavel();
        }
    }
}
