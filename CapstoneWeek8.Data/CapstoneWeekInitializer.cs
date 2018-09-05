using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CapstoneWeek8.Domain.Models;

namespace CapstoneWeek8.Data
{
    class CapstoneWeek8Initializer : DropCreateDatabaseIfModelChanges<CapstoneWeek8Context>
    {
        protected override void Seed(CapstoneWeek8Context context)
        {
            context.Cars.Add(new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Year = 1995,
                Color = "Yellow"
            });
           
            context.SaveChanges();

        }
    }
}
