using Classes.Nen;

TipoHatsu reforço = new("Reforçadores", "É a habilidade de melhorar a físicalidade do próprio corpo ou de um objeto", "São simples e determinados", "Gon e Uvogin");
TipoHatsu transmutação = new("Transmutadores", "É a habilidade de transformar aura em algo diferente ou imitar as características de algo, seja matéria sólida ou não.", "São grandes mentirosos", "Kilua e Hisoka");
TipoHatsu materialização = new("Materializadores", "Habilidade de criar objetos físicos a partir da própria aura", "São sensíveis e nervosos", "Kaito e Koltopi");
TipoHatsu emissão = new("Emissores", "É a habilidade de separar a aura do corpo", "Impacientes e não prestam atenção em detalhes", "Razor e Senritsu");
TipoHatsu especialização = new("Especialistas", "Tudo que não encaixa nas outras categorias", "Carismáticos e independentes", "Neon e Kuroro");

TipoNen tiposDeHatsu = new("Hatsu", "Existem 5 tipos de Hatsu, onde cada tipo possui propriedades diferentes");
tiposDeHatsu.AdicionarTiposDeHatsu(reforço);
tiposDeHatsu.AdicionarTiposDeHatsu(transmutação);
tiposDeHatsu.AdicionarTiposDeHatsu(materialização);
tiposDeHatsu.AdicionarTiposDeHatsu(emissão);
tiposDeHatsu.AdicionarTiposDeHatsu(especialização);

TipoBasicoNen ten = new("Ten", "O primeiro princípio, Ten, é a técnica de concentração e defesa. Ela é a base para todas as outras técnicas de Nen e é usada para manter a aura do praticante em uma camada protetora externa. A técnica envolve concentrar a aura em torno do corpo e mantê-la sob controle para que o praticante possa se proteger de ataques externos. ");
TipoBasicoNen zetsu = new("Zetsu", "O segundo princípio, Zetsu, é a técnica de supressão. Ela é usada para suprimir a aura e torná-la imperceptível para outros usuários de Nen e animais sensíveis à aura. É útil em situações em que um usuário de Nen deseja passar despercebido ou evitar ser detectado por outros usuários.");
TipoBasicoNen ren = new("Ren", "O terceiro princípio, Ren, é a técnica de intensificação. Ela é usada para aumentar a quantidade de aura que um usuário pode liberar e controlar. O treinamento de Ren é fundamental para aumentar a eficácia de habilidades de Nen que requerem uma grande quantidade de aura.");
TipoBasicoNen hatsu = new("Hatsu", "O quarto e último princípio, Hatsu, é a técnica de expressão da aura. Ela é a habilidade individual de cada usuário de Nen e é usada para expressar a aura de formas únicas e personalizadas. A habilidade de Hatsu é determinada pelo tipo de aura do usuário e sua personalidade.");

TipoNen quatroPrincipiosDoNen = new("Habilidades básicas de Nen", "Para entender plenamente o conceito de Nen, é necessário primeiro aprender os Quatro Princípios Maiores da escola de kung fu Shingen-ryu. Tudo o mais, incluindo as habilidades individuais de um praticante de Nen, é baseado nas manipulações básicas do fluxo de aura. Os Quatro Princípios Maiores, em ordem de estudo, são: Ten, Zetsu, Ren e Hatsu.");
quatroPrincipiosDoNen.AdicionarTiposDeNen(ten);
quatroPrincipiosDoNen.AdicionarTiposDeNen(zetsu);
quatroPrincipiosDoNen.AdicionarTiposDeNen(ren);
quatroPrincipiosDoNen.AdicionarTiposDeNen(hatsu);

TipoBasicoNen tipoBasicoNen = new("Quatro princípios", "Qualquer usuário pode treinar");
//tipoBasicoNen.ExibiTiposBásicosDeNen();
//Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
TipoHatsu tipoHatsu = new("\nTipos de Hatsu", "São 5 tipos de nen cuja o usuário possui uma afinidade", "Essa afinidade vem de acordo com a personalidade e características de nascença", "Exemplo: Hisoka é um manipulador, manipulando sua aura a sua vontade. Sua personalidade também é manipuladora");
//tipoHatsu.ExibiTiposDeHatsu();

CriaçãoPersonagem personagem = new CriaçãoPersonagem();
personagem.CriarPersonagem();