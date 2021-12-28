using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<Customer> GetCustomerWithOthers(Expression<Func<Customer, bool>> filter);
        void UpdateWithCsAdress(Customer customer);
    }
}
