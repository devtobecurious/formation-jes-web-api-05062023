using EmptyWebApi.Models;
namespace EmptyWebApi;

public static class JediEndpoints
{
    public static void MapJediEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Jedi", () =>
        {
            return new[] { new Jedi() };
        })
        .WithName("GetAllJedis")
        .Produces<Jedi[]>(StatusCodes.Status200OK);

        routes.MapGet("/api/Jedi/{id:min(13)}", (int id) =>
        {
            //return new Jedi { ID = id };
        })
        .WithName("GetJediById")
        .Produces<Jedi>(StatusCodes.Status200OK);

        routes.MapPut("/api/Jedi/{id}", (int id, Jedi input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateJedi")
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Jedi/", (Jedi model) =>
        {
            //return Results.Created($"/Jedis/{model.ID}", model);
        })
        .WithName("CreateJedi")
        .Produces<Jedi>(StatusCodes.Status201Created);

        routes.MapDelete("/api/Jedi/{id}", (int id) =>
        {
            //return Results.Ok(new Jedi { ID = id });
        })
        .WithName("DeleteJedi")
        .Produces<Jedi>(StatusCodes.Status200OK);
    }
}
