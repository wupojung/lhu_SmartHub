using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SmartHub.Models;

namespace SmartHub;

public class SmartHubContext : DbContext
{
  


    public SmartHubContext(DbContextOptions<SmartHubContext> options)
        : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=localhost;database=pzem;user=pzem_user;password=pzem_user_password;SslMode=none",
                ServerVersion.Parse("10.4.32", ServerType.MariaDb));
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<PzemEntiy>().ToTable<PzemEntiy>("Pzems");
    }

    public DbSet<PzemEntiy> Pzems { get; set; }
}