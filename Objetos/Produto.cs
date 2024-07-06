class Produto
{
    string nome;
    float preco;
    public void CalculaDesconto(){
        Console.WriteLine("Voce nao tem desconto");
    }

    public Produto(string nomeProduto, float precoProduto){
        nome = nomeProduto;
        preco = precoProduto;
    }
}