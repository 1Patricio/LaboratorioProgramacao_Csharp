public abstract class Funcionario
{
    public string? Nome;
    public int Matricula;
    public List<string> projetos = new List<string>();

    public Funcionario(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
    public abstract void AdicionarProjeto(int matricula, string projeto);
    public abstract void AdicionarProjeto(List<string> projetos);
}