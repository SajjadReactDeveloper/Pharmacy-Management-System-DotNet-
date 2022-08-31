using Microsoft.EntityFrameworkCore;
using ReactAPI.demo.Data.Entities;

namespace ReactAPI.demo.Data;

public class ReactJSDemoYTContext : DbContext
{
    public ReactJSDemoYTContext(DbContextOptions<ReactJSDemoYTContext> options) : base(options)
    {
    }
    public DbSet<SuperVillain> SuperVillain { get; set; }
    public DbSet<Sajjad> Sajjad { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Manufacturer> Manufacturer { get; set; }
    public DbSet<Medicine> Medicine { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
}