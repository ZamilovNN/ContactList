using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public class Company
    {
        public int ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}