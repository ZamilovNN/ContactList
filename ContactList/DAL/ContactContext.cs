using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContactList.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ContactList.DAL
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("DBConnection")
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}