using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace BankApp.DataAccess.Concrete.EntityFramework
{
    public class BankAppContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CsAccount> CsAccounts { get; set; }
        public DbSet<CsAdress> CsAdresses { get; set; }
        public DbSet<Login> Logins { get; set; }
        
        public BankAppContext():base(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=BankApp;Integrated Security=True;")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Customer>().HasOptional(c=>c.CsAdress);
            modelBuilder.Entity<Customer>().HasMany(c => c.CsAccount);
            base.OnModelCreating(modelBuilder);
        }
    }   
}
