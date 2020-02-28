using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwerty2.DAL.Database;
using Qwerty2.DAL.Repository;
using Qwerty2.Entities;

namespace Qwerty2.Services
{
    public class AboutPageService
    {
        #region KESİNLİKLE YAPMA!! - DAL IN VAROLUŞ SEBEBİNE AYKIRI!!
        //private ProjectContext database;

        //public AboutPageServices()
        //{
        //    database = new ProjectContext();
        //}

        //public AboutPage GetAboutPage()
        //{
        //    var aboutPage = database.AboutPage;

        //    return aboutPage;
        //}
        #endregion

        private AboutPageRepository _aboutRepository;

        public AboutPageService()
        {
            _aboutRepository = new AboutPageRepository();
        }

        public AboutPage GetAboutPage()
        {
            
            var model = _aboutRepository.GetAboutPage();

            return model;
        }
    }
}
