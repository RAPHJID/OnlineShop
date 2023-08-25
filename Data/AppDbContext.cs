using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Cart> Carts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<User>()
        .HasOne(u => u.Cart)
        .WithOne(c => c.User)
        .HasForeignKey<Cart>(c => c.UserId);

    modelBuilder.Entity<User>()
        .HasMany(u => u.Orders)
        .WithOne(o => o.User)
        .HasForeignKey(o => o.UserId);

    modelBuilder.Entity<Cart>()
        .HasMany(c => c.Products)
        .WithOne(p => p.Cart)
        .HasForeignKey(p => p.CartId);

    modelBuilder.Entity<Order>()
        .HasOne(o => o.Shipment)
        .WithOne(s => s.Order)
        .HasForeignKey<Shipment>(s => s.OrderId);

    modelBuilder.Entity<Order>()
        .HasOne(o => o.Payment)
        .WithOne(p => p.Order)
        .HasForeignKey<Payment>(p => p.OrderId);
    }

}


