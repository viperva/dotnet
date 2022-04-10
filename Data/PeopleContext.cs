using Microsoft.EntityFrameworkCore;
using proj.Models;

public class PeopleContext : DbContext {

    public PeopleContext (DbContextOptions options) : base(options) { }
    public DbSet<Person> Person { get; set; }
    
}