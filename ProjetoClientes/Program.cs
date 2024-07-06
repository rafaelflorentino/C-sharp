using System.Data.SqlClient;

namespace BancoCliente;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                UserID = "sa",
                Password = "12345",
                InitialCatalog = "projetoclientes",
                DataSource = "localhost\\SQLEXPRESS",
                IntegratedSecurity = false
            };


            using(SqlConnection conexao = new SqlConnection(builder.ConnectionString)){

                string sql = "SELECT  * FROM  tb_clientes";

                using(SqlCommand comando = new SqlCommand(sql, conexao)){

                    conexao.Open();

                    using( SqlDataReader leitor = comando.ExecuteReader()){

                        while(leitor.Read()){
                        // 1° Forma de pegar os dados
                        /*  System.Console.WriteLine("id: {0}", leitor["id"]);
                            System.Console.WriteLine("nome: {0}", leitor["nome"]);
                            System.Console.WriteLine("email: {0}", leitor["email"]); */

                        // 2° Forma de pegar os dados
                            System.Console.WriteLine("id: {0}", leitor.GetSqlInt32(0));
                            System.Console.WriteLine("nome: {0}", leitor.GetSqlString(0));
                            System.Console.WriteLine("email: {0}", leitor.GetSqlString(0));
                        }
                    }

                }
            }
        }
        catch (Exception e)
        {        
            System.Console.WriteLine("Erro: "+ e.ToString());
        }
    }
}
