static void Menu(){
    Console.Clear();
    System.Console.WriteLine("O que você deseja fazer: ");
    System.Console.WriteLine("1 - Abrir arquivo: ");
    System.Console.WriteLine("2 - Criar novo arquivo: ");
    System.Console.WriteLine("0 - Sair da Aplicação.");
    short option = short.Parse(Console.ReadLine());
    switch (option){
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edition(); break;
        default: Menu(); break;
    }
}

static void Open(){
    Console.Clear();
    System.Console.WriteLine("Qual o caminho do arquivo para abrir?");
    string path = Console.ReadLine();
    using(var file = new StreamReader(path)){
        string text = file.ReadToEnd();
        System.Console.WriteLine(text);
    }
    System.Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Edition(){
    Console.Clear();
    System.Console.WriteLine("Digite seu texto abaixo, caso queira sair, pressione ESC");
    System.Console.WriteLine("--------------------------");
    string text = " ";
    do{
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while(Console.ReadKey().Key != ConsoleKey.Escape);
    Save(text);
}

static void Save(string text){
    Console.Clear();
    System.Console.WriteLine(" Qual caminho para salvar o arquivo?");
    var path = Console.ReadLine();
    using(var file = new StreamWriter(path)){
        file.Write(text);
    }
    System.Console.WriteLine($"Arquivo {path} salvo com sucesso! ");
    Console.ReadLine();
    Menu();
}

Menu();