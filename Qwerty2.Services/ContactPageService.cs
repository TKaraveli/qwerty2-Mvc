using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwerty2.DAL.Repository;
using Qwerty2.Entities;

namespace Qwerty2.Services
{
    public class ContactPageService
    {
        private ContactPageRepository _contactPageRepository;

        public ContactPageService()
        {
            _contactPageRepository = new ContactPageRepository();
        }

        public ContactPage GetContactPage()
        {
            var model = _contactPageRepository.GetContactPage();

            return model;
        }
    }
}
