using Classes.Nen;

TipoHatsu refor�o = new("Refor�adores", "� a habilidade de melhorar a f�sicalidade do pr�prio corpo ou de um objeto", "S�o simples e determinados", "Gon e Uvogin");
TipoHatsu transmuta��o = new("Transmutadores", "� a habilidade de transformar aura em algo diferente ou imitar as caracter�sticas de algo, seja mat�ria s�lida ou n�o.", "S�o grandes mentirosos", "Kilua e Hisoka");
TipoHatsu materializa��o = new("Materializadores", "Habilidade de criar objetos f�sicos a partir da pr�pria aura", "S�o sens�veis e nervosos", "Kaito e Koltopi");
TipoHatsu emiss�o = new("Emissores", "� a habilidade de separar a aura do corpo", "Impacientes e n�o prestam aten��o em detalhes", "Razor e Senritsu");
TipoHatsu especializa��o = new("Especialistas", "Tudo que n�o encaixa nas outras categorias", "Carism�ticos e independentes", "Neon e Kuroro");

TipoNen tiposDeHatsu = new("Hatsu", "Existem 5 tipos de Hatsu, onde cada tipo possui propriedades diferentes");
tiposDeHatsu.AdicionarTiposDeHatsu(refor�o);
tiposDeHatsu.AdicionarTiposDeHatsu(transmuta��o);
tiposDeHatsu.AdicionarTiposDeHatsu(materializa��o);
tiposDeHatsu.AdicionarTiposDeHatsu(emiss�o);
tiposDeHatsu.AdicionarTiposDeHatsu(especializa��o);

TipoBasicoNen ten = new("Ten", "O primeiro princ�pio, Ten, � a t�cnica de concentra��o e defesa. Ela � a base para todas as outras t�cnicas de Nen e � usada para manter a aura do praticante em uma camada protetora externa. A t�cnica envolve concentrar a aura em torno do corpo e mant�-la sob controle para que o praticante possa se proteger de ataques externos. ");
TipoBasicoNen zetsu = new("Zetsu", "O segundo princ�pio, Zetsu, � a t�cnica de supress�o. Ela � usada para suprimir a aura e torn�-la impercept�vel para outros usu�rios de Nen e animais sens�veis � aura. � �til em situa��es em que um usu�rio de Nen deseja passar despercebido ou evitar ser detectado por outros usu�rios.");
TipoBasicoNen ren = new("Ren", "O terceiro princ�pio, Ren, � a t�cnica de intensifica��o. Ela � usada para aumentar a quantidade de aura que um usu�rio pode liberar e controlar. O treinamento de Ren � fundamental para aumentar a efic�cia de habilidades de Nen que requerem uma grande quantidade de aura.");
TipoBasicoNen hatsu = new("Hatsu", "O quarto e �ltimo princ�pio, Hatsu, � a t�cnica de express�o da aura. Ela � a habilidade individual de cada usu�rio de Nen e � usada para expressar a aura de formas �nicas e personalizadas. A habilidade de Hatsu � determinada pelo tipo de aura do usu�rio e sua personalidade.");

TipoNen quatroPrincipiosDoNen = new("Habilidades b�sicas de Nen", "Para entender plenamente o conceito de Nen, � necess�rio primeiro aprender os Quatro Princ�pios Maiores da escola de kung fu Shingen-ryu. Tudo o mais, incluindo as habilidades individuais de um praticante de Nen, � baseado nas manipula��es b�sicas do fluxo de aura. Os Quatro Princ�pios Maiores, em ordem de estudo, s�o: Ten, Zetsu, Ren e Hatsu.");
quatroPrincipiosDoNen.AdicionarTiposDeNen(ten);
quatroPrincipiosDoNen.AdicionarTiposDeNen(zetsu);
quatroPrincipiosDoNen.AdicionarTiposDeNen(ren);
quatroPrincipiosDoNen.AdicionarTiposDeNen(hatsu);

TipoBasicoNen tipoBasicoNen = new("Quatro princ�pios", "Qualquer usu�rio pode treinar");
//tipoBasicoNen.ExibiTiposB�sicosDeNen();
//Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
TipoHatsu tipoHatsu = new("\nTipos de Hatsu", "S�o 5 tipos de nen cuja o usu�rio possui uma afinidade", "Essa afinidade vem de acordo com a personalidade e caracter�sticas de nascen�a", "Exemplo: Hisoka � um manipulador, manipulando sua aura a sua vontade. Sua personalidade tamb�m � manipuladora");
//tipoHatsu.ExibiTiposDeHatsu();

Cria��oPersonagem personagem = new Cria��oPersonagem();
personagem.CriarPersonagem();