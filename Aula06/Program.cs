//Aulas sobre IF ELSE SWITCH em C#

// System.Console.WriteLine("Instrição If");
// System.Console.WriteLine("Cliente Especial: true/false");
// var resposta = Convert.ToBoolean(Console.ReadLine());
// if(resposta){
//     System.Console.WriteLine("Desconto de 10%");
// }
// System.Console.WriteLine("Informe o valor de x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Informe o valor de y:");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x>y){
//     System.Console.WriteLine("X é maior que Y.");
// }if(x<y){
//     System.Console.WriteLine("X é menor que Y.");
// }if(x==y){
//     System.Console.WriteLine("X é igual a Y.");
// }

// System.Console.WriteLine("Instrução If-Else");
// System.Console.WriteLine("Insira a nota do aluno:");
// var nota = Convert.ToInt32(Console.ReadLine());
// if(nota > 5){
//     System.Console.WriteLine("Aluno aprovado!");
// }else{
//     System.Console.WriteLine("Aluno reprovado...");
// }

// System.Console.WriteLine("Informe o valor de x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Informe o valor de y:");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x>y){
//     System.Console.WriteLine("X é maior que Y.");
// }else{
//     if(x<y){
//     System.Console.WriteLine("X é menor que Y.");
//     }else{
//     System.Console.WriteLine("X é igual a Y.");
//     }
// }

// System.Console.WriteLine("Estrutura Switch-case");
// int compra = 600;
// System.Console.WriteLine("Valor da compra R$ 600,00");
// System.Console.WriteLine("Informe o número de parcelas (1 - 3): ");
// var parcelas = Convert.ToInt32(Console.ReadLine());
// switch(parcelas){
//     case 1: System.Console.WriteLine($"Prestação R$ {compra/parcelas},00.");break;
//     case 2: System.Console.WriteLine($"Prestação R$ {compra/parcelas},00.");break;
//     case 3: System.Console.WriteLine($"Prestação R$ {compra/parcelas},00.");break;
//     default: System.Console.WriteLine("Valor inválido, somente aceito 1, 2 ou 3 parcelas!"); break;
// }

// System.Console.WriteLine("Informe o nome do mês");
// var mes = Console.ReadLine();
// switch(mes){
//     case "janeiro":

//     case "março":

//     case "maio":

//     case "julho":

//     case "agosto":

//     case "outubro":

//     case "dezembro":
//     System.Console.WriteLine("Este mês tem 31 dias"); break;

//     case "fevereiro":
//     System.Console.WriteLine("Este mês tem 28 ou 29 dias");break;

//     default: System.Console.WriteLine("Este mês tem 30 dias");break;
// }

// System.Console.WriteLine("Instrução While");

// int i = 0;
// do{
//     System.Console.WriteLine($"i = {i}");
//     i++;
// }while(i < 11);

// System.Console.WriteLine("Instrução For");

// int numero, resultado;
// System.Console.WriteLine("Informe um número inteiro.");
// numero = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= 10; i++){
//     resultado = numero * i;
//     System.Console.WriteLine(numero + " . " + i + " = " + resultado);
// }

// int numero2, resultado2;
// System.Console.WriteLine("Informe um número inteiro.");
// numero2 = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= 10; i++){
//     if(i == 4)
//         continue;
//     resultado2 = numero2 * i;
//     System.Console.WriteLine(numero2 + " . " + i + " = " + resultado2);
// }

//final da aula