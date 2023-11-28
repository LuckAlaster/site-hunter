namespace Classes.Nen;

internal class TipoNen
{
    public static List<TipoHatsu> listaDeHatsu = new();
    public static List<TipoBasicoNen> listaDeNen = new();
    public TipoNen(string nomeNen, string descriçãoNen)
    {
        NomeNen = nomeNen;
        DescriçãoNen = descriçãoNen;
    }
    public string NomeNen { get; }
    public string DescriçãoNen { get; }
    
    public void AdicionarTiposDeHatsu(TipoHatsu tipoHatsu)
    {
        listaDeHatsu.Add(tipoHatsu);
    }
    public void AdicionarTiposDeNen(TipoBasicoNen tipoNen)
    {
        listaDeNen.Add(tipoNen);
    }

}
