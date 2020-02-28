using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwerty2.DAL.Mappings;
using Qwerty2.Entities;

namespace Qwerty2.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        //:base("Server=;Database=;Trusted_Connection=true;")
        :base("defaultConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ContactPageMappings());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set; }

       
    }
}
