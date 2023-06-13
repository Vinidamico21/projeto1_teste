using IwantApp.Domain.Infra.Data;

namespace IwantApp.Controllers.Endpoint.Teste;

public partial class TesteGetId
{
    public static string Template => "/testeget/{id}";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(int Idteste)
    {

        var nome = NomeTeste.NomesListaTeste.FirstOrDefault(p => p.Idteste == Idteste); 
        if (nome == null)
        {
            return Results.NotFound("Nao foi possivel localizar o Id");
        }

        return Results.Ok(nome);
    }
}
