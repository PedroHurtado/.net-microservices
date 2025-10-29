using Microsoft.AspNetCore.Mvc;
using webapi.common;

namespace webapi.features.ingredient.commands;

public class CreateIngredient : IFeatureModule
{
    public record struct Request(string Name, decimal Cost);
    public record struct Response(Guid Id,string Name, decimal Cost);
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/ingredientes", async ([FromBody] Request request) =>
        {
            var response = new Response(
                Guid.NewGuid(),
                request.Name,
                request.Cost
            );

            return Results.Ok(response);
        })
        .WithName("CreateIngredient")
        .WithOpenApi();
    }

    public interface IService
    {
        Task<Response> Handler(Request req);
    }

    public class Service : IService
    {
        public Task<Response> Handler(Request req)
        {
            throw new Exception();
        }
    }
}