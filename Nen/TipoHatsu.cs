using Org.BouncyCastle.Asn1.Cms;
using System.Diagnostics;

namespace Classes.Nen;

internal class TipoHatsu
{
    public static List<TipoHatsu> listaDeHatsu = new();

    public TipoHatsu(string? nomeHatsu, string? características, string? personalidade, string? exemplos)
    {
        NomeHatsu = nomeHatsu;
        Características = características;
        Personalidade = personalidade;
        Exemplos = exemplos;
    }
    public string? NomeHatsu { get; }
    public string? Características { get; }
    public string? Personalidade { get; }
    public string? Exemplos { get; }

    public void FazerArraydeHatsus()
    {

    }
    public void AdicionarTiposDeHatsu(TipoHatsu tipoHatsu)
    {
        listaDeHatsu.Add(tipoHatsu);
    }

    public void ExibiTiposDeHatsu()
    {
        Console.WriteLine("Tipos de hatsu existentes");
        foreach (var hatsu in listaDeHatsu)
        {
            Console.WriteLine($"\nTipo de Hatsu: {hatsu.NomeHatsu}");
            Console.WriteLine($"Descrição: {hatsu.Características}");
            Console.WriteLine($"Personalidade do usuário: {hatsu.Personalidade}");
            Console.WriteLine($"Exemplos de usuários: {hatsu.Exemplos}");
        }
    }
    public void ExibirDetalhesHatsu()
    {
        Console.WriteLine($"\nTipo do Hatsu: {NomeHatsu}");
        Console.WriteLine($"Descrição: {Características}");
        Console.WriteLine($"Tipo de personalidade do usuário: {Personalidade}");
        Console.WriteLine($"Exemplos de usuários: {Exemplos}");
    }
    public void MostrarMenuHatsu()
    {
        Console.WriteLine("Digite reforço");
        Console.WriteLine("Digite transmutação");
        Console.WriteLine("Digite materialização");
        Console.WriteLine("Digite emissão");
        Console.WriteLine("Digite especialização\n");
    }
    public void EsperarEscolha()
    {
        Console.WriteLine("\nJá escolheu seu tipo de Hatsu?");
        var resposta2 = Console.ReadLine();
        if (resposta2 == "sim" || resposta2 == "Sim")
        {
            Console.Clear();
            Console.WriteLine("\nBeleza. Escolha uma das opções abaixo:");
            MostrarMenuHatsu();
        }
        else
        {
            Console.WriteLine("Aguardarei mais alguns segundos. Pressione qualquer tecla para continuar");
            Console.WriteLine("\nBeleza. Escolha uma das opções abaixo:");
            MostrarMenuHatsu();
        }
    }
    public void RelembrarHatsu()
    {
        foreach (TipoHatsu hatsu in listaDeHatsu)
        {
            Console.WriteLine("Chegou a hora de escolher seu hatsu. Se lembra de todos eles?");
            var resposta1 = Console.ReadLine();
            if (resposta1 == "sim" || resposta1 == "Sim")
            {
                Console.WriteLine("\nBeleza. Escolha uma das opções abaixo:");
                MostrarMenuHatsu();
                return;
            }
            else if (resposta1 == "não" || resposta1 == "Não")
            {
                Console.WriteLine("\nExistem 5 tipos de hatsu. Observe abaixo: ");
                ExibiTiposDeHatsu();
                EsperarEscolha();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!");
                RelembrarHatsu();
                return;
            }
        }
    }
    public void SelecionarHatsu()
    {
        TipoHatsu[] tipoHatsus = new TipoHatsu[5];
        tipoHatsus[0] = new("Reforçadores", "É a habilidade de melhorar a físicalidade do próprio corpo ou de um objeto", "São simples e determinados", "Gon e Uvogin");
        tipoHatsus[1] = new("Transmutadores", "É a habilidade de transformar aura em algo diferente ou imitar as características de algo, seja matéria sólida ou não.", "São grandes mentirosos", "Kilua e Hisoka");
        tipoHatsus[2] = new("Materializadores", "Habilidade de criar objetos físicos a partir da própria aura", "São sensíveis e nervosos", "Kaito e Koltopi");
        tipoHatsus[3] = new("Emissores", "É a habilidade de separar a aura do corpo", "Impacientes e não prestam atenção em detalhes", "Razor e Senritsu");
        tipoHatsus[4] = new("Especialistas", "Tudo que não encaixa nas outras categorias", "Carismáticos e independentes", "Neon e Kuroro");
        RelembrarHatsu();
        var hatsuDigitado = Console.ReadLine();
        foreach (TipoHatsu hatsuEscolhido in tipoHatsus)
        {
                if (hatsuDigitado == "reforço")
                {
                Console.WriteLine($"\nTipo do Hatsu: {hatsuEscolhido.NomeHatsu}");
                Console.WriteLine($"Descrição: {hatsuEscolhido.Características}");
                Console.WriteLine($"Tipo de personalidade do usuário: {hatsuEscolhido.Personalidade}");
                Console.WriteLine($"Exemplos de usuários: {hatsuEscolhido.Exemplos}");
                Console.WriteLine("\nParabéns por escolher seu hatsu :D");
                return;
                }
                else if (hatsuDigitado == "transmutação")
                {
                Console.WriteLine($"\nTipo do Hatsu: {hatsuEscolhido.NomeHatsu}");
                Console.WriteLine($"Descrição: {hatsuEscolhido.Características}");
                Console.WriteLine($"Tipo de personalidade do usuário: {hatsuEscolhido.Personalidade}");
                Console.WriteLine($"Exemplos de usuários: {hatsuEscolhido.Exemplos}");
                Console.WriteLine("\nParabéns por escolher seu hatsu :D");
                return;
                }
                else if (hatsuDigitado == "materialização")
                {
                Console.WriteLine($"\nTipo do Hatsu: {hatsuEscolhido.NomeHatsu}");
                Console.WriteLine($"Descrição: {hatsuEscolhido.Características}");
                Console.WriteLine($"Tipo de personalidade do usuário: {hatsuEscolhido.Personalidade}");
                Console.WriteLine($"Exemplos de usuários: {hatsuEscolhido.Exemplos}");
                Console.WriteLine("\nParabéns por escolher seu hatsu :D");
                return;
                }
                else if (hatsuDigitado == "emissão")
                {
                Console.WriteLine($"\nTipo do Hatsu: {hatsuEscolhido.NomeHatsu}");
                Console.WriteLine($"Descrição: {hatsuEscolhido.Características}");
                Console.WriteLine($"Tipo de personalidade do usuário: {hatsuEscolhido.Personalidade}");
                Console.WriteLine($"Exemplos de usuários: {hatsuEscolhido.Exemplos}");
                Console.WriteLine("\nParabéns por escolher seu hatsu :D");
                return;
                }
                else if (hatsuDigitado == "especialização")
                {
                Console.WriteLine($"\nTipo do Hatsu: {hatsuEscolhido.NomeHatsu}");
                Console.WriteLine($"Descrição: {hatsuEscolhido.Características}");
                Console.WriteLine($"Tipo de personalidade do usuário: {hatsuEscolhido.Personalidade}");
                Console.WriteLine($"Exemplos de usuários: {hatsuEscolhido.Exemplos}");
                Console.WriteLine("\nParabéns por escolher seu hatsu :D");
                return;
                }
                else
            {
                Console.Clear();
                Console.WriteLine("\nVocê não escolheu seu hatsu. Que pena");
                SelecionarHatsu();
                return;
            }
        }
    }
}