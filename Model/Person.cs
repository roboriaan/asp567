using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqliteEF7.Model
{
    //Yay a person
    public class Person 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSQLite("Data Source=CropsDB.sqlite");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Key(m => m.ID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
