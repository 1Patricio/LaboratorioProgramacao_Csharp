// //Pasta para TDE 3
// // 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// // Encontre o maior dentre 3 números:
// // Primeiro Número : 65465
// // Segundo Número : 64658
// // Terceiro Número : 65464
// // O primeiro número : 65465 é o maior
// int number1, number2, number3;
// System.Console.WriteLine("Informe o primeiro número para comparação: ");
// number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Informe o segundo número agora: ");
// number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Informe o terceiro e último número: ");
// number3 = Convert.ToInt32(Console.ReadLine());
// if(number1>number2){
//     if(number1>number3){
//         System.Console.WriteLine($"O número {number1} é o maior dos 3 números.");
//     }else{
//         System.Console.WriteLine($"O número {number3} é o maior dos 3 números.");
//     }
// }else if(number2>number3){
//     System.Console.WriteLine($"O número {number2} é o maior dos 3 números");
// }else{
//     System.Console.WriteLine($"O número {number3} é o maior dos 3 números.");
// }

// 2- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
// while, do-while e for.
// Os 10 primeiros números naturais são :
// 1 2 3 4 5 6 7 8 9 10
// A soma dos números é : 55
// int i, soma = 0;
// System.Console.WriteLine("Os dez primeiros números naturais são: ");
// for (i = 1; i<11; i++){
//     soma +=i;
//     System.Console.WriteLine(i);
// }
// System.Console.WriteLine($"O valor da soma deles é {soma}");

//Com DO-WHILE:
// int ii = 1;
// int soma2 = 0;
// System.Console.WriteLine("Os 10 primeiros números naturais são: ");
// do{
//     soma2 +=ii;
//     System.Console.WriteLine(ii);
//     ii++;
// }while(ii<=10);{
//     System.Console.WriteLine($"O valor da soma deles é {soma2}");
// }

// 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
// recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número 
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;

int number, i;
string continuar;
System.Console.WriteLine("Digite um número para mostrarmos a sua tabuada até o 10!");
number = Convert.ToInt32(Console.ReadLine());
continuar = "S";
while(continuar == "S"){
    if (number == 0){
    System.Console.WriteLine("Toda a tabuada de Zero(0) resulta em zero, insira outro número: ");
    number = Convert.ToInt32(Console.ReadLine());
    }else{
        for (number * (i = 1); i,11; ){

        }
    }
}

//terminar quando possível


// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1
// int i, f = 1, num;
// System.Console.WriteLine("Informe um número inteiro maior que 0");
// num = Convert.ToInt32(Console.ReadLine());
// for (i = 1; i <= num; i++){
//     f = f * i;
// }System.Console.WriteLine($"O fatorial de {num} é igual a {f}");






