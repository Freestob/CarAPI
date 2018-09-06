using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneWeek8.Domain.Models;
using CapstoneWeek8.Data.Maps;
using System.Data.Entity;

namespace CapstoneWeek8.Data
{
    public class CapstoneWeek8Context : DbContext
    {
        public CapstoneWeek8Context() : base("CapstoneWeek8")
        {
            //Drop the database and recreate on each run
           // Database.SetInitializer(new DropCreateDatabaseAlways<CapstoneWeek8Context>());
            // Create the DB if it doesn't exist.  
           // Database.SetInitializer(new CreateDatabaseIfNotExists<CapstoneWeek8Context>());
            //Will Drop and recreate if model changes.
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TaskListRevisitedContext>());
            //Custom Initializer
            Database.SetInitializer(new CapstoneWeek8Initializer());
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
