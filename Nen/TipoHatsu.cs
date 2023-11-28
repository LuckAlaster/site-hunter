using System.Text.Json;
namespace Classes.Nen;

internal class TipoHatsu
{
    public TipoHatsu(string nomeHatsu, string características, string personalidade, string exemplos) 
    {
        NomeHatsu = nomeHatsu;
        Características = características;
        Personalidade = personalidade;
        Exemplos = exemplos;
    }
    public string NomeHatsu { get; }
    public string Características { get; }
    public string Personalidade { get; }
    public string Exemplos { get; }

    public void ExibiTiposDeHatsu()
    {
        Console.WriteLine("Tipos de hatsu existentes");
        foreach (var hatsu in TipoNen.listaDeHatsu)
        {
            Console.WriteLine($"\nTipo de Hatsu: {hatsu.NomeHatsu}");
            Console.WriteLine($"Descrição: {hatsu.Características}");
            Console.WriteLine($"Personalidade do usuário: {hatsu.Personalidade}");
            Console.WriteLine($"Exemplos de usuários: {hatsu.Exemplos}");
        }
    }
    public void ExibirDetalhesHatsu()
    {
        Console.WriteLine(value: $"Tipo do Hatsu: {NomeHatsu}");
        Console.WriteLine(value: $"Descrição: {Características}");
        Console.WriteLine(value: $"Tipo de personalidade do usuário: {Personalidade}");
        Console.WriteLine(value: $"Exemplos de usuários: {Exemplos}");
    }
    public void SelecionarHatsu()
    {
        Random random = new Random();
        var indiceAleatorio = random.Next(0, TipoNen.listaDeHatsu.Count);
        Console.WriteLine("\nO seu personagem é pré disposto ao tipo de hatsu abaixo");
       // var resposta = TipoNen.listaDeHatsu[indiceAleatorio];
       // var hatsu = JsonSerializer.Deserialize<List<TipoHatsu>>(resposta)!;
        //hatsu[indiceAleatorio].ExibirDetalhesHatsu();
    }
}
