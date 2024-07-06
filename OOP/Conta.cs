namespace OOP
{
    class Conta // Vamos usar Polimorfismo para para nao acessar diretamente o saldo
    {
        private double saldo=50; // Não pode acessar externamente

        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;
            Console.WriteLine("Novo Saldo: "+this.saldo);
        }
    }
}
