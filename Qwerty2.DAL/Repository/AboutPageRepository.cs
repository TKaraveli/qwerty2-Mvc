using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwerty2.DAL.Database;
using Qwerty2.Entities;

namespace Qwerty2.DAL.Repository
{
    public class AboutPageRepository
    {
        private ProjectContext database;

        public AboutPageRepository()
        {
            database = new ProjectContext();
        }

        public AboutPage GetAboutPage()
        {
            var aboutPage = database.AboutPage.FirstOrDefault();

            return aboutPage;
        }
    }
}
