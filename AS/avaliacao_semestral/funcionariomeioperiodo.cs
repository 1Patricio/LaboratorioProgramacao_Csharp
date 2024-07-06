public class FuncionarioMeioPeriodo:Funcionario, IBonus
{
    public double SalarioHora;
    public float HorasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salario_hora, float horas_trabalhadas):base(nome, matricula)
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
        System.Console.WriteLine("_______________________________");
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
        System.Console.WriteLine("_______________________________");
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
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