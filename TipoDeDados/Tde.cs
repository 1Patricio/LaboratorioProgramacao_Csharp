//Variaveis de tipos são do tipo camelCase  ex.:notaAluno
//Metodos e classes são do tipo PascalCase ex.:NotaAluno

//1. Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine("1 = " + idade);

//2. Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine("2 = " + nome);

//3. Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;
Console.WriteLine("3 = " + altura);
//outra alternativa
double alturaDois = 3.45;
System.Console.WriteLine("Outra alternativa: 3 =" + alturaDois);

//4. Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const int ano = 12;
Console.WriteLine("4 = " + ano);

//5. Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = null;
nota = 7.80;
Console.WriteLine("5 = " + nota);

//6. Quais as diferenças entre os tipos por valor e os tipos por referência ?
// R = Os tipos por valor são armazenamentos de valores diretos, declarados por meio da variável, já os de referência, guardam o valor indiretamente em algum espaço da memória.

//7. O que é um nullable type e qual a sua utilidade ?
// R = O tipo nullable é uma declaração para a variável fazendo com que ela seja nula, e possa receber um valor posteriormente, sendo por um input, ou herdando um valor a ser informado.

//8. O que é Camel Case ? Dê um exemplo de sua aplicação.
// R = É uma regra de nomenclatura para poder nomear uma variável, no caso em questão, seria uma nomeação quando ocorre uma concatenação para variáveis do tipo valor em geral, por exemplo: notaMaria

//9. O que é Pascal Case ? Dê um exemplo de sua aplicação
// R = É uma outra regra de nomenclatura, dessa vez, para nomear classes e métodos, por exemplo: UsarFunção

//10. Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)
int x = 77;
int y = 66;
Console.WriteLine("10 = " + (x + y));
//alternativa
int x1 = 77, y2 = 66;
System.Console.WriteLine("Alternativa: 10 = " + (x1 + y2));

//11. Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
// R = Bool = false; char = '\0' (U+0000); int = 0; double = 0; float = 0; decimal = 0; string = null