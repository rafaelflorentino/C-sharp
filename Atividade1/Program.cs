using System;
namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar nome");
            string val_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereco");
            string val_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou Jurídica (j)");
            string val_tipo = Console.ReadLine();
            if(val_tipo == "f")
            {
                // ---- Pessoa Física ----
                Pessoa_Fisica pf =  new Pessoa_Fisica();
                pf.nome = val_nome;
                pf.endereco = val_endereco;
                Console.WriteLine("informar CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("informar RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("------ Pessoa Física -------- ");
                Console.WriteLine("Nome .............:" + pf.nome);
                Console.WriteLine("Endereço .........:" + pf.endereco);
                Console.WriteLine("CPF ..............:" + pf.cpf);
                Console.WriteLine("RG ...............:" + pf.rg);
                Console.WriteLine("Valor de Compra...:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto ..........:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar ....:" + pf.total.ToString("C"));
            }
            if(val_tipo == "j")
            {
                // ---- Pessoa Jurídica ----
                Pessoa_Juridica pj =  new Pessoa_Juridica();
                pj.nome = val_nome;
                pj.endereco = val_endereco;
                Console.WriteLine("informar CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("------ Pessoa Física -------- ");
                Console.WriteLine("Nome .............:" +pj.nome);
                Console.WriteLine("Endereço .........:" +pj.endereco);
                Console.WriteLine("CNPJ .............:" +pj.cnpj);
                Console.WriteLine("IE ...............:" +pj.ie);
                Console.WriteLine("Valor de Compra...:" +pj.valor.ToString("C"));
                Console.WriteLine("Imposto ..........:" +pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar ....:" +pj.total.ToString("C"));
            }

        }
    }
}