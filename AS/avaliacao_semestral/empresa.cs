using System.Reflection.PortableExecutable;

public class Empresa
{
    public List<Funcionario> Funcionarios = new List<Funcionario>();

    public void Adicionar (Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        Funcionarios.RemoveAll(f => f.Matricula == matricula); //Observação: fora usado a lambda para facilitar o entendimento e funcionamento desta função do código, uma vez que o elemento f equivale a cada objeto na lista Funcionario, e a lambda(=>) é um separador de parâmetros. À esquerda do operador, temos os parâmetros da função; à direita, a expressão que será avaliada ou o bloco de código que será executado.
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }

}