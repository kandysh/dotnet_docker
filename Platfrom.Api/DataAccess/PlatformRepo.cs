using Platfrom.Api.Models;

namespace Platfrom.Api.DataAccess;

public class PlatformRepo : IPlatformRepo
{
    private readonly PlatformContext _context;

    public PlatformRepo(PlatformContext context)
    {
        _context = context;
    }

    public void CreatePlatform(Platform platform)
    {
        _context.Platforms.Add(platform);
        SaveChanges();
    }

    public IEnumerable<Platform> GetAllPlatforms()
    {
        return _context.Platforms;
    }

    public Platform GetPlatformById(int id)
    {
        return _context.Platforms.First(p => p.Id.Equals(id));
    }

    public bool SaveChanges()
    {
        return _context.SaveChanges() > 0;
    }
}
