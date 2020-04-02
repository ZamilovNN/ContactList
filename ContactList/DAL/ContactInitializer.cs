using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContactList.Models;

namespace ContactList.DAL
{
    public class ContactInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContactContext>
    {
        protected override void Seed(ContactContext context)
        {
            /*
            var contactOne = new Contact { FirstName = "Иванов", LastName = "Иван", CompanyID = 1 };
            var contactTwo = new Contact { FirstName = "Петров", LastName = "Петр", CompanyID = 2};
            var contacts = new List<Contact>
            {
               contactOne,
               contactTwo
            };
            contacts.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();

            var companies = new List<Company>
            {
                new Company{ Name = "Рога и копыта", Contacts = contacts},
                new Company{ Name = "Топтыжка"}
            };

            companies.ForEach(c => context.Companies.Add(c));
            context.SaveChanges();

            var contactInformations = new List<ContactInformation>
            {
                new ContactInformation{ Contact = contactOne, InfoType = InfoType.Email, InfoDescription = "Ivanov@ivanov.ru" },
                new ContactInformation{ Contact = contactOne, InfoType = InfoType.Phone, InfoDescription = "8123456789" },
                new ContactInformation{ Contact = contactTwo, InfoType = InfoType.Skype, InfoDescription = "@petya" }
            };

            contactInformations.ForEach(ci => context.ContactInformations.Add(ci));
            context.SaveChanges();
            */
        }
    }
}