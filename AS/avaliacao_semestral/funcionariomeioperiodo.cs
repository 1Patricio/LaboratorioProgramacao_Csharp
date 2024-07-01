public class FuncionarioMeioPeriodo:Funcionario
{
    private double SalarioHora;
    private float HorasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salario_hora, float horas_trabalhadas)
    {
        Nome = nome;
        Matricula = matricula;
        SalarioHora = salario_hora;
        HorasTrabalhadas = horas_trabalhadas;
    }

    public override double CalcularSalario()
    {
        return SalarioHora * HorasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matrícula: " + Matricula);
        Console.WriteLine("Salário: " + CalcularSalario());
    }
}