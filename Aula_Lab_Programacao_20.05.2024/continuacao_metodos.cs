// Calculadora
using System.Reflection.PortableExecutable;
public class Calculadora{
    public Calculadora(double x1, double x2){
        num1 = x1;
        num2 = x2;
    }     
    double num1;
    double num2; 
    public void Somar(int x, int y){
       var resulta = x + y;
       System.Console.WriteLine(resulta);
    }
    public void Somar(int x, int y, int z){
       var resulta = x + y + z;
       System.Console.WriteLine(resulta);
    }
    // public void Somar(int a, int b, int c){
    //      var resulta = a + b + c;
    //      System.Console.WriteLine(resulta);
    // }
    //Não pode haver dois métodos com a mesma assinatura!
    public double Divisao(double a, double b){
        var resultado = a / b;
        return resultado;
    }
    public double Divisao(){
        return num1 / num2;
    }
}
//Sobrecarga de métodos, ocorre quando temos métodos com o mesmo nome, mas com parâmetros diferentes. Essa utilização é muito comum em linguagens orientadas a objetos, e é uma forma de polimorfismo.
//Método construtor, é um método especial que é chamado quando um objeto é criado a partir de uma classe. O construtor não tem um tipo de retorno, nem mesmo void. O construtor é chamado quando um objeto é criado, tem o mesmo nome da classe e não possui passagem de argumentos.
