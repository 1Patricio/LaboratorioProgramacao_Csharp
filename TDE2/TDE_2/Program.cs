// // Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
// string nome = "Paulo";
// int idade = 17;
// double nota = 7.5;
// System.Console.WriteLine($"{nome} tem {idade} anos e {nota} nota");

// Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
// escapes.
// string nome = "Paulo \n";
// int idade = 17;
// double nota = 7.5;
// System.Console.WriteLine($"{nome} {idade}\n {nota}");

// Para qual tipo de dados você pode converter um float implicitamente (Não ocasiona perda de dados e nem código) ?
// ( ) int
// (x) double
// ( ) long
// (x) decimal

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada)
// ( ) int para long
// ( ) double para long
// ( ) double para float
// (x) decimal para float
// ( ) long para int
// ( ) double para decimal

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
// System.Console.WriteLine("Insira 3 letras em uma ordem para inversão. \n");
// System.Console.WriteLine("Insira a primeira letra: \n");
// string? letra1 = Console.ReadLine();
// System.Console.WriteLine("Insira a segunda letra: \n");
// string? letra2 = Console.ReadLine();
// System.Console.WriteLine("E agora, a última letra: \n");
// string? letra3 = Console.ReadLine();

// System.Console.WriteLine($"A inversão da sua sequência é: {letra3}, {letra2} e {letra1}.");
// System.Console.WriteLine(letra3 + " " + letra2 + " " + letra1);

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// var nome = "Maria";
// System.Console.WriteLine(nome);
// // (V) string resultado = 100.ToString();
// string resultado = 100.ToString();
// System.Console.WriteLine(resultado);
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// object o = 12.45m;
// System.Console.WriteLine(o);
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado:
// using System.Diagnostics.Contracts;
// using System.Runtime.InteropServices;

// System.Console.WriteLine("Insira um valor: \n");
// double valor1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Insira outro valor: \n");
// double valor2 = Convert.ToDouble(Console.ReadLine());

// double soma = valor1 + valor2;
// double subt = valor1 - valor2;
// double multi = valor1 * valor2;
// double expo = Math.Pow(valor1, valor2);
// double divid = valor1 / valor2;
// double modul = valor1 % valor2;

// System.Console.WriteLine($"A soma dos números é {soma}; a subtração dos números é {subt}; a multiplicação é {multi}; a exponenciação dentre os números é {expo}; a divisão entre os números é {divid}; e o módulo dos números é {modul}");

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário)
// System.Console.WriteLine("Insira o Nome: \n");
// string nome = Console.ReadLine();
// System.Console.WriteLine("Insira a Senha: \n");
// int senha = Convert.ToInt32(Console.ReadLine());
// string loginUser = nome == "maria" || nome == "admin" ? "Sim" : "Não";
// int loginPassword = senha == 123 ? 1 : 0;
// string loginGeral = loginUser == "Sim" && loginPassword == 1 ? "Login feito com sucesso" : "Login inválido";
// System.Console.WriteLine(loginGeral);

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
// System.Console.WriteLine("Insira um númeroi: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Insira outro número: ");
// int y = Convert.ToInt32(Console.ReadLine());
// string ehPar = x % 2 == 0 ? "é par" : "não é par";
// string ehPar2 = y % 2 == 0 ? "é par" : "não é par";
// System.Console.WriteLine($"O número {x} {ehPar} e o número {y} {ehPar2}");