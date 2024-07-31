namespace DesignPatters.PatternsComportamental.Interpreter.Jumanji
{
    public class Contexto
    {
        public Contexto(string personagem)
        {
            Personagem = personagem;
            Conteudo = String.Empty;
        }

        public string Personagem { get; set; }
        public string Conteudo { get; set; }
    }
}