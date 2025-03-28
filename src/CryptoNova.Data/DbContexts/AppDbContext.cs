using CryptoNova.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CryptoNova.Data.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users {  get; set; } 
    public DbSet<Key> Keys { get; set; }
    public DbSet<Encryption> Encryption { get; set; }
}
