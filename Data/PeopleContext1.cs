#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proj.Models;

namespace proj.Data
{
    public class PeopleContext1 : DbContext
    {
        public PeopleContext1 (DbContextOptions<PeopleContext1> options)
            : base(options)
        {
        }

        public DbSet<proj.Models.Person> Person { get; set; }
    }
}
