using BlazorDemoUI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemoUI.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<DispleyPersonModel> PersonModels { get; set; }
}
