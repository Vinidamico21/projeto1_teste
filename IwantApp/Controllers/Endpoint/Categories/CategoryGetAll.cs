using IwantApp.Domain.Infra.Data;
namespace IwantApp.Controllers.Endpoint.Categories;

public static class CategoriesGetAll
{
    public static string Template => "/categories";

    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    
    public static Delegate Handle => Action;

    public static IResult Action(ApplicationDbContext context)
    {
        
        var categories = context.Categories.ToList();
        var response = categories.Select(c => new CategoryResponse { Id =c.Id, Name = c.Name, Active = c.Active });

        context.SaveChanges();

        return Results.Ok(response);

    }

}
