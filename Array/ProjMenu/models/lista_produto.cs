public class ListaProdutos:Produto
{
    List<Produto> lista = new List<Produto>();

    public Produto CadastrarProduto()
    {
        
        Codigo = DateTime.Now.Millisecond;
        System.Console.WriteLine("Digite o nome do produto:");
        Nome = System.Console.ReadLine();
        System.Console.WriteLine("Digite a descrição do produto:");
        Descricao = System.Console.ReadLine();
        System.Console.WriteLine("Digite a quantidade do produto:");
        Quantidade = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Digite o preço do produto:");
        Preco = decimal.Parse(System.Console.ReadLine());
        lista.Add(this);
        return this;
    }

    public void ListarProdutos()
    {
        foreach (var produto in lista)
        {
            System.Console.WriteLine("_____________________________________________-");
            System.Console.WriteLine($"Código: {produto.Codigo}");
            System.Console.WriteLine($"Nome: {produto.Nome}");
            System.Console.WriteLine($"Descrição: {produto.Descricao}");
            System.Console.WriteLine($"Quantidade: {produto.Quantidade}");
            System.Console.WriteLine($"Preço: {produto.Preco}");
            System.Console.WriteLine("_____________________________________________-");
        }
    }
    public void ExcluirProdutos()
    {
        System.Console.WriteLine("Digite o código do produto que deseja excluir:");
        int codigo = int.Parse(System.Console.ReadLine());
        Produto produto = lista.Find(produto => produto.Codigo == codigo);
        lista.Remove(produto);
        System.Console.WriteLine("Produto excluído com sucesso!");
    }
}