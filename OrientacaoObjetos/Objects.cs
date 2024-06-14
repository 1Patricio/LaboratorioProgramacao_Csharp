//Classes

int x = 100;

Pessoa p1 = new Pessoa(); // como "chamar" uma classe, criando uma variável que vai receber essa classe (que seria, nesse caso, um objeto)
p1.nome = "Maria";
p1.idade = 23;
p1.sexo = "Feminino";

Pessoa p2;
// p2.nome="Caetano";
// p2.idade = 20;
// p2.sexo = "Masculino";

p2 = p1; //A variável p2 recebe os valores de p1, ou seja, apontam para o mesmo endereço na memória HEAP

System.Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");
System.Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");


class Pessoa {//classe é como se fosse um planejamento para um objeto, as instruções e esquemas dele 
    public string nome;
    public int idade;
    public string sexo;
} //Como fazer uma classe