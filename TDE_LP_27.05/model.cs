// Exercício 1: Criação de uma Classe Simples
// Crie uma classe chamada Produto com as propriedades Nome e Preco. Implemente um construtor padrão que inicializa Nome como "Desconhecido" e Preco como 0.0, e um construtor parametrizado que aceita valores para Nome e Preco.
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

public class Produto
{
    string name;
    double price;
    public Produto()
    {
        this.name = "Desconhecido";
        this.price = 0.0;
    }
    public Produto(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
    // Exercício 2: Sobrecarregando um Método
    // Na classe Produto do exercício anterior, crie um método ExibirInfo que exibe as informações do produto. Em seguida, sobrecarregue este método para que ele aceite um parâmetro booleano exibirPreco. Se exibirPreco for verdadeiro, o método deve exibir também o preço do produto.
    public void ShowInfo()
    {
        System.Console.WriteLine($"Nome do produto: {this.name}");
        System.Console.WriteLine($"Preço do produto: {this.price}");
    }
    bool showPrice;
    public void ShowInfo(bool showPrice)
    {
        System.Console.WriteLine($"Nome do produto: {this.name}");
        System.Console.WriteLine("Ver preço do produto? (true/false)");
        showPrice = bool.Parse(Console.ReadLine());
        if (showPrice == true)
        {
            System.Console.WriteLine($"Preço do Produto: {this.price}");
        }
    }
}

// Exercício 3: Calculadora com Sobrecarga de Métodos
// Crie uma classe chamada Calculadora com métodos sobrecarregados para somar dois, três e quatro números inteiros.
public class Calculadora
{
    float n1, n2, n3, n4;
    public void Somar()
    {
        System.Console.WriteLine("Informe o primeiro número: ");
        n1 = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe o segundo número: ");
        n2 = float.Parse(Console.ReadLine());
        float soma = n1 + n2;
        System.Console.WriteLine(soma);
    }
    public void Somar(float n1, float n2, float n3)
    {
        float soma = n1 + n2 + n3;
        System.Console.WriteLine(soma);
    }
    public void Somar(float n1, float n2, float n3, float n4)
    {
        float soma = n1 + n2 + n3 + n4;
        System.Console.WriteLine(soma);;
    }
}

// Exercício 4: Sobrecarga de Construtores
// Crie uma classe Aluno com propriedades Nome e Idade. Implemente um construtor padrão que inicializa Nome como "Não Informado" e Idade como 0. Crie também um construtor parametrizado que aceita Nome e Idade como argumentos.
public class Aluno{
    string name;
    int age;
    public Aluno(){
        this.name = "Não informado";
        this.age = 0;
    }
    public Aluno(string name, int age){
        this.name = name;
        this.age = age;
    }
    public void ShowClassmate(){
        System.Console.WriteLine($"Nome do aluno: {this.name}");
        System.Console.WriteLine($"Idade do aluno: {this.age}");
    }
}
// Exercício 5: Classe de Funcionário
// Crie uma classe Funcionario com as propriedades Nome, Cargo e Salario. Implemente um construtor padrão que inicializa Nome como "Desconhecido", Cargo como "Não Informado" e Salario como 0.0. Crie também um construtor parametrizado que aceita Nome, Cargo e Salario.
public class Funcionario{
    string name;
    string job;
    double payment;
    public Funcionario(){
        this.name = "Desconhecido";
        this.job = "Não Informado";
        this.payment = 0.0;
    }
    public Funcionario(string name, string job, double payment){
        this.name = name;
        this.job = job;
        this.payment = payment;
    }
    public void ShowEmployee(){
        System.Console.WriteLine($"Nome do funcionário: {this.name}");
        System.Console.WriteLine($"Cargo do funcionário: {this.job}");
        System.Console.WriteLine($"Salário do funcionário: {this.payment}");
    }
}

// Exercício 6: Classe de Retângulo
// Crie uma classe Retangulo com propriedades Altura e Largura. Implemente métodos sobrecarregados CalcularArea para calcular a área do retângulo. O método deve funcionar tanto com a altura e largura da instância quanto com valores passados como parâmetros.
public class Retangulo{
    float altura, largura, area;
    public float CalcularArea(){
        System.Console.WriteLine("Insira a altura do retângulo: ");
        altura = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Insira a largura do retângulo:");
        largura = float.Parse(Console.ReadLine());
        area = altura * largura;
        return area;
    }
    public float CalcularArea(float altura, float largura){
        area = altura * largura;
        return area;
    }
    public void ExibirArea(){
        System.Console.WriteLine($"A àrea do retângulo é: {area}");
    }
}

// Exercício 7: Biblioteca de Livros
// Crie uma classe Livro com propriedades Titulo, Autor e Ano. Implemente um construtor padrão e um construtor parametrizado que aceita Titulo, Autor e Ano. Crie um método ExibirInfo para exibir as informações do livro.
public class Livro{
    string titulo, autor;
    int ano;
    public Livro(){
        System.Console.WriteLine("Título do livro: ");
        titulo = Console.ReadLine();
        System.Console.WriteLine("Autor do livro: ");
        autor = Console.ReadLine();
        System.Console.WriteLine("Ano do livro: ");
        ano = int.Parse(Console.ReadLine());  
    }
    public Livro(string titulo, string autor, int ano){
        this.titulo = titulo;
        this.autor = autor;
        this.ano = ano;
    }
    public void ExibirInfos(){
        System.Console.WriteLine($"Título do livro: {this.titulo}");
        System.Console.WriteLine($"Autor do livro: {this.autor}");
        System.Console.WriteLine($"Ano do livro: {this.ano}");
    }
}

// Exercício 8: Sobrecarregando Construtores
// Crie uma classe ContaBancaria com propriedades NumeroConta, Titular e Saldo. Implemente um construtor padrão que inicializa NumeroConta e Titular como "Desconhecido" e Saldo como 0.0. Crie também um construtor parametrizado que aceita NumeroConta, Titular e Saldo.
public class ContaBancaria{
    float saldo;
    string numeroConta, titular;
    public ContaBancaria(){
        this.numeroConta = "Desconhecido";
        this.titular = "Desconhecido";
        this.saldo = 0.0f;
    }
    public ContaBancaria(string numeroConta, string titular, float saldo){
        this.numeroConta = numeroConta;
        this.titular = titular;
        this.saldo = saldo;
    }
    public void Exibir_Informacoes_Conta(){
        System.Console.WriteLine($"Número da conta: {this.numeroConta}");
        System.Console.WriteLine($"Titular da conta: {this.titular}");
        System.Console.WriteLine($"Saldo da conta: {this.saldo}");
    }
}

// Exercício 9: Classe de Veículo
// Crie uma classe Veiculo com as propriedades Marca, Modelo e Ano. Implemente um construtor padrão que inicializa Marca, Modelo como "Desconhecido" e Ano como 0. Crie também um construtor parametrizado que aceita Marca, Modelo e Ano.
public class Veiculo{
    string marca, modelo;
    int ano;
    public Veiculo(){
        this.marca = "Desconhecido";
        this.modelo = "Desconhecido";
        this.ano = 0;
    }
    public Veiculo(string marca, string modelo, int ano){
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }
    public void FichaVeiculo(){
        System.Console.WriteLine($"Marca do veículo: {this.marca}");
        System.Console.WriteLine($"Modelo do veículo: {this.modelo}");
        System.Console.WriteLine($"Ano do veículo: {this.ano}");
    
    }
}

// Exercício 10: Polimorfismo com Sobrecarga de Métodos
// Crie uma classe Conversor com métodos sobrecarregados para converter diferentes tipos de dados. Implemente métodos para converter int para double, double para int, string para int, e string para double.
public class Conversor{
    public double Converter(int num){
        double numDouble = num;
        return numDouble;
    }
    public int Converter(double num){
        int intNum = (int)num;
        return intNum;
    }
    public int Converter(string num){
        int intNum = int.Parse(num);
        return intNum;
    }
    public double ConverterDouble(string num){
        if(!string.IsNullOrEmpty(num))
        {
            double doubleNum = double.Parse(num);
            return doubleNum;
        }else{
            System.Console.WriteLine("Informe um valor válido para conversão, pois o que inseriu não é um número!");
            return 0;
        }
        
    }
}