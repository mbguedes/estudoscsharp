//ScreenSound
string mensagemDeBoasVindas = "Bem vindo ao Screen Sound!!";

Console.WriteLine(mensagemDeBoasVindas);

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█ █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█ ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhaMenu = Console.ReadLine()!;
    int opcaoEscolhaMenuNumerica = int.Parse(opcaoEscolhaMenu);
    switch (opcaoEscolhaMenuNumerica)
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhaMenuNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhaMenuNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhaMenuNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhaMenuNumerica);
            break;
        case 0: Console.WriteLine("Você escolheu sair");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();