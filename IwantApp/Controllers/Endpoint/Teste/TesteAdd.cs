using IwantApp.Domain.Infra.Data;
using static IwantApp.Controllers.Endpoint.Teste.TesteGetId;
using IwantApp.Controllers.Endpoint.Teste;


namespace IwantApp.Controllers.Endpoint.Teste;

public class TesteAdd
{
    public static string Template => "/testeadd";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(TesteRequest testeRequest)
    {

        //// Verificar se o IdTeste já existe na lista
        bool idTesteExists = TesteGetId.NomeTeste.NomesListaTeste
            .Any(t => t.Idteste == testeRequest.idTeste);
        if (idTesteExists)
        {

        //// Retornar uma resposta indicando que o IdTeste já existe
            return Results.BadRequest("O IdTeste já existe na lista.");
        }

        var testeusuario = new NomeTeste(testeRequest.idTeste, testeRequest.nomeCompleto);
        TesteGetId.NomeTeste.NomesListaTeste.Add(testeusuario);


        //// Ordenar a lista em ordem crescente pelo Idteste
        TesteGetId.NomeTeste.NomesListaTeste = TesteGetId.NomeTeste
            .NomesListaTeste.OrderBy(t => t.Idteste).ToList();

        return Results.Ok(TesteGetId.NomeTeste.NomesListaTeste);
    }
}




