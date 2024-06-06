using coursework.Moduls;
using Microsoft.EntityFrameworkCore;

public class ConnectionDB : DbContext
{
    public DbSet<User> users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=D:\\dev\\db\\universitydb.sqlite");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<User>().HasKey(u => u.user_id);
    }
}