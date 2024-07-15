using System;
using System.IO;
using Codificacao.Classes;

class Program
{
    static void Main(string[] args)
    {
        string opcao = "";

        List<PessoaJuridica> Empresas = new List<PessoaJuridica>();

        do
        {
            Console.Clear();
            Console.WriteLine(@"
            1 - Cadastrar PJ 
            2 - Visualizar PJ
            3 - Sair
            ");

            opcao = Console.ReadLine()!;
            PessoaJuridica metodosPJ = new PessoaJuridica();

            if (opcao == "1")
            {
                Console.Clear();
                PessoaJuridica pj = new PessoaJuridica();

                Console.WriteLine("Digite o nome da Pessoa Juridica: ");
                pj.Nome = Console.ReadLine()!;

                Console.WriteLine("Digite o CNPJ da Pessoa Juridica: ");
                pj.CNPJ = Console.ReadLine()!;

                Console.WriteLine("Digite o rendimento da Pessoa Juridica: ");
                pj.Rendimento = float.Parse(Console.ReadLine()!);

                metodosPJ.Inserir(pj);
                Empresas.Add(pj);
            }
            else if (opcao == "2"){
                Console.Clear();
                foreach (var pj in Empresas)
                {
                    Console.WriteLine($"Nome: {pj.Nome}, CNPJ: {pj.CNPJ}, Rendimento: {pj.Rendimento}");
                }  
                Thread.Sleep(2000);              
            }
            else if (opcao == "3"){
                Console.Clear();
                Console.WriteLine("Obrigado por usar o sistema.");
            }            
        } while (opcao != "3");
    }
}

