using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPetManager
{
    public class PetManagerContext : DbContext
    {
        public PetManagerContext() :base("name=PetManagerConnectionString") {}

        // Tenemos un DbSet por entidad a persistir

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
