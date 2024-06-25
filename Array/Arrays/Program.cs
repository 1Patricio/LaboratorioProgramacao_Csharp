// // Sintaxe para criação de arrays

// int[] notas = new int[5];

// notas[0] = 90;
// notas[1] = 85;
// notas[2] = 88;
// notas[3] = 92;
// notas[4] = 95;

// for(int i = 0; i < notas.Length; i++)
// {
//     System.Console.WriteLine($"Aluno : {i+1} nota: {notas[i]}");
// }

// // Sintaxe para criação de list

// List<string> tarefas = new List<string>();

// tarefas.Add("Estudar C#");
// tarefas.Add("Ler um livro de programação");
// tarefas.Add("Estudar inglês");

// tarefas.Remove("Estudar inglês");

// foreach(string t in tarefas)
// {
//     System.Console.WriteLine(t);
// }

using System;

List<Veiculo> veiculos = new List<Veiculo>();
Carro carro = new Carro();
Moto moto = new Moto();
veiculos.Add(carro);
veiculos.Add(moto);

foreach(Veiculo vehicle in veiculos)
{
    vehicle.Acelerar();
    vehicle.ExibirVelocidade();
    vehicle.Frear();
    vehicle.ExibirVelocidade();
}

