public abstract class Funcionario
{
    private string? Nome;
    private int Matricula;

    public Funcionario(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public abstract double CalcularSalario();

    public abstract void ExibirInformacoes();
}