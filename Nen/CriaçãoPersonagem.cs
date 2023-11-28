namespace Classes.Nen;

internal class CriaçãoPersonagem 
{
    public static List<TipoBasicoNen> listaDeNen = new();
    public List<CriaçãoPersonagem> Personagens = new();

    public string? Nome { get; set; }
    public int? Idade { get; set; }
    public string? Profissão { get; set; }
    public string? Nen { get; set; }
    public void CriarPersonagem()
    {
        Console.WriteLine("Digite o nome do personagem");
        string? nome = Console.ReadLine();
        Console.WriteLine("\nQual a idade do seu personagem?");
        string? imput = Console.ReadLine();
        int? idade = int.Parse(imput);
        Console.WriteLine("\nO que ele faz da vida?");
        string? profissão = Console.ReadLine();
        Console.WriteLine("\nEle já sabe usar TipoNen? Digite S para sim ou N para não");
        string? nen = Console.ReadLine();
        if(nen == "S")
        {
            Console.WriteLine("\nDeseja saber mais informações sobre Nen? Digite S para sim ou N para não");
            string? queroSaber = Console.ReadLine();
            if (queroSaber == "S")
            {
                Console.WriteLine("Muito Bem! As informações são:");
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listaDeNen = TipoNen.listaDeNen;
                TipoBasicoNen exibir = new("Quatro princípios", "Qualquer usuário pode treinar");
                exibir.ExibiTiposBásicosDeNen();
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
        Console.WriteLine("\nBeleza! Então continuemos em frente com a criação");
        Console.WriteLine("\n As informações estão corretas? \nDigite 'S' para sim ou 'N' para não");
        Console.WriteLine($"\n Nome: {nome} \n Idade: {idade} \n Profissão: {profissão} \n Usuário de TipoNen: {nen}");
        string? correto = Console.ReadLine();
        if (correto == "S")
        {
            Console.Clear();
            CriaçãoPersonagem personagem = new CriaçãoPersonagem()
            {
                Nome = nome,
                Idade = idade,
                Profissão = profissão,
                Nen = nen,
            };
            personagem.Personagens.Add(personagem);
            Console.WriteLine($"\n Meus Parabéns! Seu personagem {personagem.Nome} foi criado com sucesso");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nDigite novamente as informações");
            CriarPersonagem();
        }
    }
}
