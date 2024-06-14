//"Projeto de Calculadora em C#"
Menu();
static void Menu(){
    Console.Clear();
    System.Console.WriteLine("CALCULADORA");
    System.Console.WriteLine("1 - Soma;");
    System.Console.WriteLine("2 - Subtração;");
    System.Console.WriteLine("3 - Multiplicação;");
    System.Console.WriteLine("4 - Divisão;");
    System.Console.WriteLine("0 - Sair;");
    System.Console.WriteLine("Selecione uma opção acima para calcular: ");
    short option = short.Parse(Console.ReadLine());

    switch(option){
        case 1: Soma(); break;
        case 2: Subtr(); break;
        case 3: Mult(); break;
        case 4: Divis(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
    }

}

static void Soma(){
    Console.Clear();
    System.Console.WriteLine("Digite o primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o segundo valor: ");
    float num2 = float.Parse(Console.ReadLine());
    float resulta = num1 + num2;
    System.Console.WriteLine("O resultado da soma é :" + resulta);
    System.Console.ReadKey();
    Menu();
}

static void Subtr(){
    Console.Clear();
    System.Console.WriteLine("Digite o primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o segundo valor: ");
    float num2 = float.Parse(Console.ReadLine());
    float resulta = num1 - num2;
    System.Console.WriteLine($"O resultado da subtração é : {resulta}");
    Console.ReadKey();
    Menu();
}

static void Divis(){
    Console.Clear();
    System.Console.WriteLine("Digite o primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o segundo valor: ");
    float num2 = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"O resultado da divisão é : {num1 / num2}");
    Console.ReadKey();
    Menu();
}

static void Mult(){
    Console.Clear();
    System.Console.WriteLine("Digite o primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o segundo valor: ");
    float num2 = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"O resultado da multiplicação é : {num1 * num2}");
    Console.ReadKey();
    Menu();
}