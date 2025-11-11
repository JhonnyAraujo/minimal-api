using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{
  public DbSet<Administrador> Administradores { get; set; } = default!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseMySql("string de conexão", ServerVersion.AutoDetect("string de conexao"));
  }
}