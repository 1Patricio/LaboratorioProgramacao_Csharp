double altura, peso; //Declaração de variáveis do tipo double
int idade; //Declaração de variávei do tipo int
string nome, etaria, peso1; // Declaração de variável do tipo string
//todas elas vão ser usadas para tipar e definir os "inputs" que vamos solicitar ao usuário
bool loop = true; //Declaração de variável do tipo boolean
do{//Abertura de Loop Do-While, para executar o programa, até que o usuário decida interromper o loop
    System.Console.WriteLine("Olá, vamos calcular seu IMC!");//Mensagem imprimida na tela para apresentação
    System.Console.WriteLine("Informe, primeiramente, sua altura (em metros):");//segunda mensagem que vai solicitar uma entrada de dado do usuário
    altura = Convert.ToDouble(Console.ReadLine());//primeira variável que vai receber a entrada de dados do usuário, observe que ela está convertendo o dado para o tipo declarado no começo do código
    System.Console.WriteLine("Em seguida, informe seu peso (em kilos):");//terceira mensagem para solicitar uma outra entrada de dados do usuário
    peso = Convert.ToDouble(Console.ReadLine());//segunda variável que vai receber uma outra entrada de dados solicitada na linha anterior
    System.Console.WriteLine("Agora, informe sua idade:");//quarta mensagem para solicitar uma entrada de dados do usuário
    idade = int.Parse(Console.ReadLine());//terceira variável que vai receber a entrada na linha anterior
    System.Console.WriteLine("E por último, diga para nós o seu nome:");//quinta e última solicitação de entrada de dados para o usuário, finalizando as solicitações
    nome = Console.ReadLine();//quarta e última variável que vai receber o valor da entrada de dados na linha anterior
    double IMC = peso / (altura*altura); //declaração de variável que vai receber dois valores para calcular o IMC conforme os dados recebidos pelo usuário
    if(IMC<=18.5){ //abertura de condicional, até a linha 38, vai fazer um primeiro tratamento dos dados apresentados e calculados pelo programa, para definir o IMC do usuário e retornar alguma das hipóteses definidas, sendo elas abaixo apresentadas.
        peso1 = "IMC = Abaixo do Peso!";;//neste retorna um IMC baixo
    }else{
        if(IMC > 18.5 && IMC <= 24.9){
            peso1 = "IMC = Peso normal!";//nesta retorna um IMC normal
        }else{
            if(IMC > 24.9 && IMC <= 29.9){
                peso1 = "IMC = Sobrepeso!";//nesta retorna um IMC alterado
            }else{
                peso1 = "IMC = Obesidade";//nessa retorna um IMC alto
            }
        }
    }
    if(idade <= 19){ //Abertura de condicional para definir a faixa etária do usuário, também fazendo um tratamento do dado informado no começo do código para definir em quam condição o usuário de enquadra
        etaria = "Jovem!";
    }else{
        if(idade >19 && idade <=59){
            etaria = "Adulto!";
        }else{
            etaria ="Idoso!";
        }
    }
    System.Console.WriteLine($"Relatório: {nome}, tem {idade} anos, seu {peso1} e sua faixa etária é {etaria}");//impressão dos dados em um relatório linear, das entradas solicitadas e dados finais após o tratamento e enquadramento das hipóteses previstas nos campos If e Else
    System.Console.WriteLine("Deseja executar novamente? (S/N)");//solicitação para executar o código novamente, ou encerrar o programa
    string executar = Console.ReadLine().ToUpper();//variável que vai receber a entrada do usuário e vai executar o código novamente ou encerrar o programa
    if (executar == "S"){//abertura de condicional para retornar o encerramento do programa ou execução novamente
        loop = true;
    }else{
        loop = false;
        System.Console.WriteLine("Obrigado por utilizar nosso programa, até logo!");
    }
}
while(loop == true);//loop while que vai fazer com que o código seja executado até que o usuário defina na variável declarada na linha 41 seja "false"