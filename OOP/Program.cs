using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo private saldo
            Conta c = new Conta();
            c.Depositar(100);

            // Herança Veiculo -> Carro
            Carro carro = new Carro{
                Modelo = "Tesla XD",
                Ano = 2023,
                QuantidadePortas = 2
            };

            Console.WriteLine("\n Herença Carro");
            Console.WriteLine("Modelo: "+ carro.Modelo);
            Console.WriteLine("Ano: "+ carro.Ano);
            Console.WriteLine("Numero de Portas:"+carro.QuantidadePortas);
        }

    }
}