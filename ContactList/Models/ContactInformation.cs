using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public enum InfoType
    {
        Phone, Email, Skype, Other
    }

    public class ContactInformation
    {
        public int ContactInformationID { get; set; }
        [Display(Name = "Контакт")]
        public int ContactId { get; set; }
        [Display(Name = "Тип")]
        public InfoType InfoType { get; set; }
        [Display(Name = "Значение")]
        public string InfoDescription { get; set; }

        public virtual Contact Contact { get; set; }
    }
}