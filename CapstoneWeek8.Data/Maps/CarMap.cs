using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CapstoneWeek8.Domain.Models;

namespace CapstoneWeek8.Data.Maps
{
    class CarMap : EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Make);
            Property(x => x.Model);
            Property(x => x.Year);
            Property(x => x.Color);
        }
    }
}
