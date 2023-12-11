namespace Classes.Nen;

internal class TipoNen
{
    public static List<TipoBasicoNen> listaDeNen = new();
    public TipoNen(string nomeNen, string descriçãoNen)
    {
        NomeNen = nomeNen;
        DescriçãoNen = descriçãoNen;
    }
    public string NomeNen { get; }
    public string DescriçãoNen { get; }

    public void AdicionarTiposDeNen(TipoBasicoNen tipoNen)
    {
        listaDeNen.Add(tipoNen);
    }

}
