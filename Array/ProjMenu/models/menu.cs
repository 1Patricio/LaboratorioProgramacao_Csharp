using System.ComponentModel;

public class Menu
{
    public int Opcao;
    public string? Produto;
    List<Produto> lista = new List<Produto>();

    public int MenuPrincipal()
    {
        Console.Clear();
        System.Console.WriteLine("Escolha uma opção:");
        System.Console.WriteLine("1 - Cadastrar produtos");
        System.Console.WriteLine("2 - Listar produtos");
        System.Console.WriteLine("3 - Remover produtos");
        System.Console.WriteLine("4 - Sair");
        Opcao = int.Parse(Console.ReadLine());
        return Opcao;
    }

    public void Cadastrar(int Opcao = 1)
    {
        Console.Clear();
        Produto produto = new Produto("", 0, 0, "");
        produto.InfoProduto();
        lista.Add(produto);
        System.Console.WriteLine("Produto cadastrado com sucesso!");
    }

    public void Listar(int Opcao = 2)
    {
        Console.Clear();
        foreach (var item in lista)
        {
            System.Console.WriteLine(item.Nome);
        }
    }
}

//Terminar