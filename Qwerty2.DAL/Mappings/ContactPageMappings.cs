using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwerty2.Entities;

namespace Qwerty2.DAL.Mappings
{
    public class ContactPageMappings : EntityTypeConfiguration<ContactPage>
    {
        public ContactPageMappings()
        {
            ToTable("Contact", "blog");
        }
    }
}
