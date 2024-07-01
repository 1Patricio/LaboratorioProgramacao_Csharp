public class FuncionarioTempoIntegral:Funcionario
{
    private double SalarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salario_mensal):base(Nome, Matricula)
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
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matrícula: " + Matricula);
        Console.WriteLine("Salário: " + CalcularSalario());        
    }
}