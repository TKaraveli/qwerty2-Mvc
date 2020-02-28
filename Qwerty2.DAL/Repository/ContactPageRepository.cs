using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwerty2.DAL.Database;
using Qwerty2.Entities;

namespace Qwerty2.DAL.Repository
{
    public class ContactPageRepository
    {
        private ProjectContext database;

        public ContactPageRepository()
        {
            database = new ProjectContext();
        }

        public ContactPage GetContactPage()
        {
            var model = database.ContactPage.FirstOrDefault();

            return model;
        }
    }
}
