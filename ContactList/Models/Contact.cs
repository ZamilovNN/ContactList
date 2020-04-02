using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactList.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [Display(Name = "Организация")]
        public int CompanyID { get; set; }
        [Display(Name = "Должность")]
        public string JobPosition { get; set; }
        [Display(Name = "Фамилия")]
        public string FirstName { get; set; }
        [Display(Name = "Имя")]
        public string LastName { get; set; }
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }
        [Display(Name = "Полное имя")]
        public string FullName
        {
            get {
                return string.Format("{0} {1}{2}", FirstName, LastName,
                    string.IsNullOrWhiteSpace(MiddleName) ? string.Empty : string.Format(" {0}", MiddleName));
            }
            set { }
        }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "datetime2")]
        [Display(Name = "Дата рождения")]        
        public DateTime BirthDay { get; set; }
        [Display(Name = "Контактная информация")]
        public virtual ICollection<ContactInformation> ContactInfomations { get; set; }
        public virtual Company Company { get; set; }

        /// <summary>
        // Создать контактную информацию по сотруднику.
        /// </summary>
        /// <returns>Контактная информация.</returns>
        public ContactInformation CreateEmployeeInfo()
        {
            var contactInfo = new ContactInformation();
            contactInfo.Contact = this;
            return contactInfo;
        }

    }
}