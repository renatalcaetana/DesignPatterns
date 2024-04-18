namespace DesignPatters.PatternsCriacao.Prototype
{
    public class Cliente
    {
        public void ConsumirDadosEtudios()
        {
            var gerenciador = new GerenciadorVendasStudio();
            gerenciador["24m"] = new Studio("24m2", "FinaEmpreendimento", 180000M);
            gerenciador["26m"] = new Studio("26m2", "Financiamentos Aurora", 190000M);
            gerenciador["28m"] = new Studio("28m2", "Imovéis tabajara", 200000M);

            StudioModel firstClone01 = gerenciador["24m"].Clone();
            StudioModel firstClone02 = gerenciador["24m"].Clone();
            StudioModel studio26 = gerenciador["26m"].Clone();
            StudioModel studio28 = gerenciador["2m8"].Clone();
        }
    }
}
