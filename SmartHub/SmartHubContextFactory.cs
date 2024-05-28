using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SmartHub;

public class SmartHubContextFactory : IDesignTimeDbContextFactory<SmartHubContext>
{
    public SmartHubContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SmartHubContext>();
        return new SmartHubContext(optionsBuilder.Options);
    }
}