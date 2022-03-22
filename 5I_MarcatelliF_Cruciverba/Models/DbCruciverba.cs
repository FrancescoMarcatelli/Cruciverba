using Microsoft.EntityFrameworkCore;
public class DbCruciverba : DbContext {
    public DbSet<Cruciverba> Cruciverba { get; set; }
    public DbSet<Suggerimento> Suggerimenti { get; set; }
    public DbCruciverba (DbContextOptions<DbCruciverba> options) : base (options) { }
}