using Platfrom.Api.DataAccess;
namespace Platfrom.Api.Endpoints;

public static class PlatformEndpoints
{
    public static RouteGroupBuilder MapPlatforms(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/platform");
        group.MapGet(
            "/all",
            (IPlatformRepo reposiotry) => Results.Ok(reposiotry.GetAllPlatforms())
        );
        return group;
    }
}
