// Screen Sound
string mensagemBoasVindas = "Bem vindo ao Screen Sound";
// List<String> ListaDasBandas= new List<String> {"U2,The Beatles, Calypso"};
Dictionary<String,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("The Beatles", new List<int>{10,8,6});
bandasRegistradas.Add("Tropikalia", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
    𝑺𝑪𝑹𝑬𝑬𝑵 𝑺𝑶𝑼𝑵𝑫");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\n Digite sua opção:");
    string  opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica){
        case 1: RegistrarBanda(); break;
        case 2: ExibirBandasRegistradas(); break;
        case 3: AvaliarUmaBanda(); break;
        case 4: ExibirMedia(); break;
        case -1: Console.WriteLine("Voce escolheu a opção "+ opcaoEscolhidaNumerica); break;
        default: Console.WriteLine("Opção inválida");break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int quatidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quatidadeDeLetras, '#');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Média da Banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda: {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
ExibirLogo();
ExibirOpcoesDoMenu();