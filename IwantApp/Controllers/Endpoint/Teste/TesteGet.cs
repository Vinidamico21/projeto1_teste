using IwantApp.Domain.Infra.Data;

namespace IwantApp.Controllers.Endpoint.Teste;

public class TesteGet
{
    public static string Template => "/testeget";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action() 
    {   
        return Results.Ok(TesteGetId.NomeTeste.NomesListaTeste); 
    }

}    


