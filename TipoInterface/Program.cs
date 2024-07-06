using System;

namespace TipoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.CodigoBarras = "123456789";
            pagamento.Pagar(50);
            Console.WriteLine("Codigo de barras: "+pagamento.CodigoBarras);
            pagamento.Pagar(50,30);
            
         
        }
    }
}
