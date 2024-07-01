public class Gato:Mamifero,IAnimal
{
    public Gato(string nome):base(nome)
    {
    }
    public void EmitirSom()
    {
        Console.WriteLine("Miau");
    }
}