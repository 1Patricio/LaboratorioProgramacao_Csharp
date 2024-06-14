public class Autor{
    public string? nome, nacionalidade;

    public void MostrarInfo(string nome, string nacionalidade){
        Console.WriteLine($"Nome: {this.nome = nome}");
        Console.WriteLine($"Nacionalidade: {this.nacionalidade = nacionalidade}");  
    }
}

public class Livro{
    string? Titulo;
    Autor? Autor;
    double Preco;

    public Livro(string titulo, Autor autor){
        this.Titulo = titulo;
        this.Autor = autor;
    }

    public Livro(string titulo_argumento, Autor autor_argumento, double preco_argumento){
        this.Titulo = titulo_argumento;
        this.Autor = autor_argumento;
        this.Preco = preco_argumento;
    }

    public void MostrarInfo(){
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor.nome}");
        Console.WriteLine($"Preço: {Preco}");
    }

    public double AplicarDesconto(double preco){
        System.Console.WriteLine("Informe a porcentagem de desconto: ");
        double desc = double.Parse(Console.ReadLine());
        return preco - (preco * (desc / 100));
    }

    public int AplicarDesconto(int preco){
        System.Console.WriteLine("Informe o valor de desconto: ");
        int desc = int.Parse(Console.ReadLine());
        return preco - desc;
    }
}