using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Qwerty2.Entities
{   
    [Table("About", Schema = "blog")]
    public class AboutPage
    {
        public int Id { get; set; } 

        public string TitleName { get; set; }

        public string AboutDescription { get; set; }

    }
}
