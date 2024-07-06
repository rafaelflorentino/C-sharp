class Pagamento : IPagamentos
{
    public string CodigoBarras {get; set;}

    public void Pagar(double valor)
    {
        Console.WriteLine("Pagando conta de: "+ valor);
    }

    public void Pagar(double valor, double valor2) // Sobrecarga de métodos
    {
        Console.WriteLine("Pagando Duas contas Juntas: "+ (valor+valor2));
    }
    
}
