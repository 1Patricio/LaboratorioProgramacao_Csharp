using System.Diagnostics.Contracts;

static int MenuPrincipal()
{
    System.Console.WriteLine("Escolha uma das opções:");
    System.Console.WriteLine("1 - Cadastrar produto.");
    System.Console.WriteLine("2 - Excluir produto.");
    System.Console.WriteLine("3 - Listar produtos cadastrados.");
    System.Console.WriteLine("0 - Sair.");
    int opcao = Convert.ToInt32(System.Console.ReadLine());
    return opcao;
}


ListaProdutos listaProdutos = new ListaProdutos();
do
{
    switch (MenuPrincipal())
    {

        case 1:
            Produto produto = new Produto();
            listaProdutos.CadastrarProduto();
            System.Console.WriteLine("Produto cadastrado com sucesso!");
            break;
        case 2:
            listaProdutos.ExcluirProdutos();
            break;
        case 3:
            listaProdutos.ListarProdutos();
            break;

    }
}
while (MenuPrincipal() != 0);
