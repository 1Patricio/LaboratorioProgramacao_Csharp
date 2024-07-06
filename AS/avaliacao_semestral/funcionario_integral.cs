public class FuncionarioTempoIntegral:Funcionario, IBonus
{
    public double SalarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salario_mensal) : base(nome, matricula)
    {
        Nome = nome;
        Matricula = matricula;
        SalarioMensal = salario_mensal;
    }

    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()
    {
        System.Console.WriteLine("_____________________________________");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matrícula: " + Matricula);
        Console.WriteLine("Salário: " + CalcularSalario());
        if(projetos.Count > 0)
        {
            System.Console.WriteLine("Projetos:");
            foreach (var projeto in projetos)
            {
                System.Console.WriteLine(projeto);
            }
        }
        else
        {
            System.Console.WriteLine("Nenhum projeto atribuído.");
        }
        System.Console.WriteLine("_____________________________________");       
    }

    public double CalcularBonus()
    {
        return SalarioMensal * 0.1;
    }

    public override void AdicionarProjeto(int matricula, string projeto)
    {
        projetos.Add(projeto);
    }

    public override void AdicionarProjeto(List<string> projetos)
    {
        foreach (var projeto in projetos)
        {
            this.projetos.Add(projeto);
        }
    }
}