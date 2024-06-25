public class Produto
{
    public string? Nome;
    public double Preco;
    public float Quantidade;
    public string? Descricao;

    public Produto(string nome, double preco, float quantidade, string descricao)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
        this.Descricao = descricao;
    }

    public void InfoProduto(){
        System.Console.WriteLine($"Nome Produto:");
        string nome = Console.ReadLine();
        System.Console.WriteLine($"Preço:");
        double preco = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"Quantidade:");
        float quantidade = float.Parse(Console.ReadLine());
        System.Console.WriteLine($"Descrição:");
        string descricao = Console.ReadLine();
    }
}