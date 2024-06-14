//"Projeto de Cronômetro em C#"
static void Start(int time){

    int currentTime = 0;
    while(currentTime != time){
        Console.Clear();
        currentTime++;
        System.Console.WriteLine(currentTime);
        Thread.Sleep(1000);//função que faz com que o sistema crie intervalos durante definidos milissegundos
        
    }
    Console.Clear();
    System.Console.WriteLine("Finalizado, retornando para o menu...");
    Thread.Sleep(2500);
    Menu();
}
static void Menu(){
    Console.Clear();
    System.Console.WriteLine("S = segundos");
    System.Console.WriteLine("M = minutos");
    System.Console.WriteLine("0 = Encerrar programa.");
    System.Console.WriteLine("Quanto tempo desejas contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length-1,1));
    int time = int.Parse(data.Substring(0, data.Length-1));
    int multiplier = 1;
    if(type == 'm')
        multiplier = 60;
    if(time == 0)
        System.Environment.Exit(0);
    
    PreStart(time*multiplier);
}
static void PreStart(int time){
    Console.Clear();
    System.Console.WriteLine("Preparar...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Apontar...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Vai!");
    Thread.Sleep(2500);

    Start(time);
}
Menu();
