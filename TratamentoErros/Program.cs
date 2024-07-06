Console.WriteLine("Hello, World!");

try
{
    int[] numeros = {1, 2, 3};
    Console.WriteLine(numeros[10]); // Error
}
catch (System.Exception e)
{
    Console.WriteLine("Nome do erro: "+ e.Message);
    
}
