internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.nome = "Caetano";
        p1.idade = 20;
        p1.sexo = "Masculino";
        p1.Comer();
        p1.Caminhar(500 /*ou declarar uma variável com um valor e tipo correspondente*/);
        string job = p1.Trabalhar();
        System.Console.WriteLine(job);
        System.Console.WriteLine($"Nome: {p1.nome}, Idade: {p1.idade}, Sexo: {p1.sexo}");

        Pessoa p2 = new Pessoa();
        p2.nome = "Letícia";
        p2.idade = 21;
        p2.sexo = "Feminino";

        System.Console.WriteLine($"Nome: {p2.nome}, Idade: {p2.idade}, Sexo: {p2.sexo}");
    }
    public class Pessoa{
    //Atributos
    public string nome;
    public int idade;
    public string sexo;
    //Métodos
    public void Comer(){
        System.Console.WriteLine("Pessoa comendo");
    }
    public void Caminhar(int passos){
        System.Console.WriteLine($"O {nome} deu {passos} passos");
    }
    public string Trabalhar(){
        string trabalho = "Pessoa trabalhando";
        return trabalho;
    }
}
}