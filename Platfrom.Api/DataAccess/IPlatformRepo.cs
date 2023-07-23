using Platfrom.Api.Models;

namespace Platfrom.Api.DataAccess;

public interface IPlatformRepo
{
    bool SaveChanges();
    IEnumerable<Platform> GetAllPlatforms();
    Platform GetPlatformById(int id);
    void CreatePlatform(Platform platform);
}
