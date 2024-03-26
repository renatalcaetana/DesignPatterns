namespace DesignPatters.PatternsCriacao.Singleton
{
    public class Client
    {
        public void ConsumirDB()
        {
            var instancia = ContextDB.Instance;
            instancia.ExecutaQuery("Select * from NOME_TABELA");

            instancia = ContextDB.Instance;
            instancia.ExecutaQuery("Insert into NOME_TABELA (valor) values (0001)");

            instancia = ContextDB.Instance;
            instancia.ExecutaQuery("Update NOME_TABELA valor=0002 where Id = 01");
        }
    }
}
