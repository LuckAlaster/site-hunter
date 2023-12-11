namespace Classes.Nen;

internal class Personagem
{
    public static List<TipoBasicoNen> listaDeNen = new();
    public List<Personagem> Personagens = new();

    public string? NomePersonagem { get; set; }
    public int? Idade { get; set; }
    public string? Profissão { get; set; }
    public string? Nen { get; set; }
    public TipoHatsu? TipoHatsu { get; }
    public TipoBasicoNen? Ten { get; set; }
    public void CriarPersonagem()
    {
        TipoHatsu tipoHatsu = new("Nome do Hatsu do Personagem", "Tipo de Hatsu que ele controla", "De acordo com sua personalidade", "Hatsu do Personagem");
        Console.WriteLine("Digite o nome do seu Personagem");
        string? nome = Console.ReadLine();
        Console.WriteLine("\nQual a idade do seu Personagem?");
        string? imput = Console.ReadLine();
        int? idade = int.Parse(imput);
        Console.WriteLine("\nO que ele faz da vida?");
        string? profissão = Console.ReadLine();
        Console.WriteLine("\nEle já sabe usar Nen?");
        string? nen = Console.ReadLine();
        if(nen == "Sim" || nen == "sim")
        {
            Console.WriteLine("\nDeseja saber mais informações sobre Nen?");
            string? queroSaberNen = Console.ReadLine();
            if (queroSaberNen == "Sim" || queroSaberNen == "sim")
            {
                Console.WriteLine("Muito Bem! As informações são:");
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listaDeNen = TipoNen.listaDeNen;
                TipoBasicoNen exibir = new("Quatro princípios", "Qualquer usuário pode treinar");
                exibir.ExibiTiposBásicosDeNen();
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nTudo bem. Continuemos a criação do personagem");
            }
        }
        Console.WriteLine("\nEle já sabe usar Hatsu?");
        string? hatsu = Console.ReadLine();
        if (hatsu == "Sim" || hatsu =="sim")
        {
            Console.WriteLine("\nDeseja saber mais informações sobre Nen?");
            string? queroSaberHatsu = Console.ReadLine();
            if (queroSaberHatsu == "Sim" || queroSaberHatsu == "sim")
            {
                TipoHatsu TipoHatsuSelecionado = new("Nome", "Decrição", "Personalidade", "Exemplo");
                TipoHatsuSelecionado.SelecionarHatsu();
                tipoHatsu = TipoHatsuSelecionado;
                
            }
            else
            {
                Console.WriteLine("\nTudo bem. Continuemos a criação do personagem");
            }
        }
        Console.WriteLine("\nBeleza! Então continuemos em frente com a criação");
        Console.WriteLine("\n As informações estão corretas? \n");
        Console.WriteLine($"\n NomePersonagem: {nome} \n Idade: {idade} \n Profissão: {profissão} \n Usuário de TipoNen: {nen} \n Seu tipo de Hatsu: {tipoHatsu.NomeHatsu}");
        string? correto = Console.ReadLine();
        if (correto == "Sim" || correto == "sim")
        {
            Console.Clear();
            Personagem personagemNovo = new()
            {
                NomePersonagem = nome,
                Idade = idade,
                Profissão = profissão,
                Nen = nen,
            };
            personagemNovo.Personagens.Add(personagemNovo);
            Console.WriteLine($"\n Meus Parabéns! Seu personagemNovo {personagemNovo.NomePersonagem} foi criado com sucesso");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nDigite novamente as informações\n");
            CriarPersonagem();
        }
    }
}
