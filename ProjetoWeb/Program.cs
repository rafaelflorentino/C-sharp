namespace ProjetoWeb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.UseStaticFiles();        

        app.MapGet("/", () => "Home Page");

        app.MapGet("/produtos", (HttpContext contexto) => 
            {
                contexto.Response.Redirect("produtos.html", false);
            }
        );

        app.MapGet("/cliente", () => "Cliente");

        // Pegar valores pela url http://localhost:5105/clientes?nome=rafael
        app.MapGet("/clientes", (string nome, string email) => $"O nome do cliente é: {nome} \nO email é: {email} ");
   
        Pessoa p1 = new Pessoa() {id=1, nome ="Ana"};

        // app.MapGet("/fornecedores", () =>
        //     $"O fornecedor é: {p1.id} - {p1.nome}"
        // );
        app.MapGet("/fornecedores", (HttpContext contexto) => {

            string pagina = "<h1> Fornecedores </h1>";
            pagina = pagina + $"<h2> ID: {p1.id} - Nome: {p1.nome} </h2>";
            contexto.Response.WriteAsync(pagina);
        });

       app.MapGet("/api", (Func<object>) ( () => {
            return new{
                id = p1.id, p1.nome
            };
        }
        ));

        app.MapGet("/fornecedoresEnviarDados", (int id, string nome) =>
        {
           p1.id = id;
           p1.nome=nome;
           return "Dados Inseridos com sucesso";
        } );       

        Banco dba=new Banco();
        dba.carregarBanco();

        app.MapGet("/banco", (HttpContext contexto) => {

            var valoresdalista="";
            //List<Pessoa> listaaux = dba.GetLista();
            foreach(Pessoa aux in dba.GetLista())
            {
                valoresdalista = valoresdalista + $"<b>ID:</b> {aux.id} - <b>Nome:</b> {aux.nome}<br>";
            }

            //return valoresdalista;
            contexto.Response.WriteAsync(valoresdalista);
        });

        app.Run();
    }
}
