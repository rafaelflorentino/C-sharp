public class Livro{
    public int Id {get;set;}
    public string Titulo {get;set;}
    public double Preco {get;set;}

    public List<Autor> Autores {get;set;}

    public Livro(int id, string titulo, double preco, List<Autor> autores)
    {
        Id = id;
        Titulo = titulo;
        Preco = preco;
        Autores = autores;
    }

}