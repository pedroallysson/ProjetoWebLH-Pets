namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Proejto Web - LH Pets versão 1");

        app.UseStaticFiles();

        app.MapGet("/index", (HttpContext contexto)=> {
            contexto.Response.Redirect("indext.html", false);
        } );

        Banco dba = new Banco();
        app.MapGet("/listaClientes", (HttpContext contexto)=> {

            contexto.Response.WriteAsync(dba.GetListaString());
        });

        app.Run();
    }
}
