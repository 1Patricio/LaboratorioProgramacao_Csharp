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
        Funcionarios.RemoveAll(f => f.Matricula == matricula);
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }

}