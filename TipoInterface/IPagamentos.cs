interface IPagamentos
{
    string CodigoBarras {  get;set; }

    void Pagar(double valor);
}
