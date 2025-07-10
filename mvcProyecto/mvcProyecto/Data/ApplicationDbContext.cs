using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    //Aqui todos los modelos que se creen 
    public DbSet<Producto> Producto { get; set; }
}

