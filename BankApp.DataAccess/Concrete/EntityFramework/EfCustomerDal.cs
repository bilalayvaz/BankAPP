using BankApp.DataAccess.Abstract;
using BankApp.Entities.Abstract;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BankAppContext>, ICustomerDal
    {
        public List<Customer> GetCustomerWithOthers(Expression<Func<Customer, bool>> filter)
                                                    
        {
            using (DbContext context = new BankAppContext())
            {
                return filter == null ?
                    context.Set<Customer>().ToList() :
                    context.Set<Customer>().Include(x=>x.CsAccount).Include(x=>x.CsAdress).Where(filter).ToList();
            }
        }

        public void UpdateWithCsAdress(Customer customer)
        {
            using (BankAppContext context = new BankAppContext())
            {
                var guncel = context.Customers.Include(x => x.CsAdress).Include(x => x.CsAccount)
                        .Single(c => c.Id == customer.Id);
                context.Entry(guncel).CurrentValues.SetValues(customer);
                context.Entry(guncel.CsAdress).CurrentValues.SetValues(customer.CsAdress);
                context.SaveChanges();
            };
        }
    }
}
