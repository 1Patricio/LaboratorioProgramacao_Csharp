Autor autor1 = new Autor();
autor1.MostrarInfo("Machado de Assis", "Brasileiro");
Livro livro1 = new Livro("Dom Casmurro", autor1, 50.00);
livro1.MostrarInfo();
Console.WriteLine($"Preço com desconto: {livro1.AplicarDesconto(50.00)}");
Console.WriteLine($"Preço com desconto: {livro1.AplicarDesconto(50)}");