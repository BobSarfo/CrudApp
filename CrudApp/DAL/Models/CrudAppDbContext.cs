using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CrudApp.Models
{
    public partial class CrudAppDbContext : DbContext
    {
        public CrudAppDbContext()
            : base("name=CrudApp")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
