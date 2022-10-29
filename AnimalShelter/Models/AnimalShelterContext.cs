using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : IdentityDbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      :base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder); //this line needed for authentication to run properly with seeded database
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Tucker", Species = "Dog", Age = 9, Fixed = true },
        new Animal { AnimalId = 2, Name = "Frodo", Species = "Cat", Age = 15, Fixed = false },
        new Animal { AnimalId = 3, Name = "Steve", Species = "Dog", Age = 8, Fixed = true}
      );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}