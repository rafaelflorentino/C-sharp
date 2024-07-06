

public class Program { 
    static void Main(string[] args) { 

        // Chamada da Função. 
        ImprimirNome("Claudia"); 

        // Biblioteca random
        Random dado = new Random(); 
        int lados = dado.Next(1, 7); 
        Console.WriteLine(lados);

        // Biblioteca Math
        float numero = 81; 
        Console.Write(Math.Sqrt(numero));
    } 

    // Declaração da Função. 
    static void ImprimirNome(string nome) { 
        Console.WriteLine(nome); 
    } 
      
} 