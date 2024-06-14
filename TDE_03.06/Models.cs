// Exercício 1: Classe Base e Classe Derivada
// Crie uma classe base Veiculo com as propriedades Marca e Ano. Crie uma classe derivada Carro que adicione a propriedade Modelo e um método ExibirDetalhes que exibe todas as informações do carro.
using System.Collections.Specialized;
using System.Runtime.ConstrainedExecution;

public class Veiculo{
    public string Marca;
    public int Ano;
}

public class Carro:Veiculo{
    public string Modelo;

    public void ExibirDetalhes(){
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Modelo: {Modelo}");
    }
}

// Exercício 2: Sobrescrita de Método
// Crie uma classe base Animal com um método virtual EmitirSom. Crie uma classe derivada Gato que sobrescreva o método EmitirSom para exibir "O gato mia".
public class Animal{
    public virtual void EmitirSom(){}
}
class Gato:Animal{
        
    public override void EmitirSom(){
        Console.WriteLine("O gato mia");
    }
}

// Exercício 3: Modificadores de Acesso
// Crie uma classe Pessoa com um campo privado nome e uma propriedade pública Nome. Adicione um método ExibirNome que exibe o nome da pessoa. Crie uma classe derivada Funcionario que adicione um campo protegido salario e um método para definir o salário.
public class Pessoa{
    private string NomePrivado;
    public string NomePublico;

    public void ExibirNome(){
        Console.WriteLine(NomePublico);
    }
}

class Funcionario:Pessoa{
    protected double Salario;


    public double DefinirSalario(double salario){
        this.Salario = salario;
        System.Console.WriteLine("Salário do funcionário");
        salario = double.Parse(Console.ReadLine());
        return salario;
    }
}

// Exercício 4: Construtores em Classes Derivadas
// Crie uma classe base Produto com um construtor que aceita nome e preco. Crie uma classe derivada Eletronico que adicione a propriedade Garantia e um construtor que aceite nome, preco e garantia.

public class Produto{
    public string Nome;
    public double Preco;
}

public class Eletronico:Produto{
    public string Garantia;

    public Eletronico(string nome, double preco, string garantia){
        this.Nome = nome;
        this.Preco = preco;
        this.Garantia = garantia;
    }
}

// Exercício 5: Polimorfismo com Herança
// Crie uma classe base Forma com um método virtual CalcularArea. Crie classes derivadas Quadrado e Circulo que sobrescrevam o método CalcularArea para calcular a área específica de cada forma.

public class Forma{
    public virtual void CalcularArea(){}
}

public class Quadrado:Forma{
    float lado1, lado2;
    public override void CalcularArea(){
        System.Console.WriteLine("Informe o lado 1 do quadrado: ");
        lado1 = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe o lado 2 do quadrado: ");
        lado2 = float.Parse(Console.ReadLine());
        Console.WriteLine(lado1*lado2);
    }
}

public class Circulo:Forma{
    double pi = 3.14;
    double raio, area;
    public override void CalcularArea(){
        System.Console.WriteLine("Informe o raio do círculo: ");
        raio = double.Parse(Console.ReadLine());
        area = pi * (raio * raio);
        System.Console.WriteLine(area);
    }
}