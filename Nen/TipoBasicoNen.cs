using System.Text.Json;
namespace Classes.Nen;

internal class TipoBasicoNen
{
    public TipoBasicoNen(string nomeNen, string descriçãoNen)
    {
        NomeNen = nomeNen;
        DescriçãoNen = descriçãoNen;
    }
    public string NomeNen { get; }
    public string DescriçãoNen { get; }

    public void ExibiTiposBásicosDeNen()
    {
        Console.WriteLine("Os quatro princípios básicos de Nen que qualquer usuário pode aprender são: ");
        foreach (var nen in TipoNen.listaDeNen)
        {
            Console.WriteLine($"\nTipo de Nen: {nen.NomeNen}");
            Console.WriteLine($"Descrição: {nen.DescriçãoNen}");
        }
    }
}
