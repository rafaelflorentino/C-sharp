using System;

class Program
{
  static void Main(string[] args)
  {
    // Objeto Produto
    Produto p = new Produto("garrafa", 90);
    p.CalculaDesconto();

    // Objeto Carro
    Carro c = new Carro();
    c.Andar();
    c.Frear();

    // Lista de objetos Autor
    var autores = new List<Autor>()
    {
      new Autor(){nome="Augusto Cury", email="augusto@gmail.com"},
      new Autor(){nome="Agatha Christie", email="agatha@gmail.com"},
      new Autor(){nome="Clarice Lispector.", email="clarice@gmail.com"},
      new Autor(){nome="Machado de Assis", email="machado@gmail.com"}
    };

    Console.WriteLine("\nQuantidade de Autores: " + autores.Count);

    autores.ForEach(autor => Console.WriteLine(autor.nome));


    // Lista de objetos Editora
    var editoras = new List<Editora>()
     {
        new Editora(1,"Darkside"),
        new Editora(2, "Moderna"),
        new Editora(3, "Rocco")
     };

    Console.WriteLine("\nQuantidade de Editoras: " + editoras.Count);

    editoras.ForEach(editora => Console.WriteLine(editora.nome));

    // Objeto Livro com lista de autores
    Livro livro = new Livro(1, "IT a coisa", 55, autores);

    Console.WriteLine($"\n\nTítulo do Livro: {livro.Titulo}");

    Console.WriteLine("Autores:");
    foreach (var autor in livro.Autores)
    {
      Console.WriteLine(autor.nome);
    }
  }
}