using BankApp.Business.Abstract;
using BankApp.Business.ValidationRules.FluentValidation;
using BankApp.DataAccess.Abstract;
using BankApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
       
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), new ValidationContext<object>(customer));
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

   

        public List<Customer> GetAll()
        {
            //Business code   
            return _customerDal.GetAll();
        }

       
        //Expression<Func<Customer, bool>> filterByCustomerNo(int customerNo)
        //{
        //    return x => x.CustomerNo == customerNo;
        //}

        public Customer GetCustomerByCustomerId(int customerId)
        {
            return _customerDal.Get(x => x.Id == customerId);
        }

        public Customer GetCustomerByCustomerNo(int customerNo)
        {
            return _customerDal.Get(x => x.CustomerNo == customerNo);
        }

        //public List<Customer> GetEnabledCustomerAccountsWithCustomerId(int customerId)
        //{ 
        //    return _customerDal.GetAll(c=>c.CsAccount.Any(y=>y.AccountState) && c.Id == customerId);
        //}

        public List<Customer> GetCustomerByTcNo(string tcNo)
        {
            return _customerDal.GetAll(c => c.TcNo == tcNo);
        }

        public int GetRandomUniqueCustomerNo()
        {
            Random rnd = new Random();
            int randomCustomerNo = rnd.Next(100000000,999999999);
            var customerNo = _customerDal.Get(c => c.CustomerNo == randomCustomerNo);
            if (customerNo==null)
            {
                return randomCustomerNo;
            }
            else
            {
                return GetRandomUniqueCustomerNo();
            }
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public List<Customer> GetCustomerWithOthersByCustomerId(int customerId)
        {
            return _customerDal.GetCustomerWithOthers(x => x.Id == customerId);
        }

        public List<Customer> GetCustomerWithOthersByCustomerTcNo(string tcNo)
        {
            return _customerDal.GetCustomerWithOthers(x => x.TcNo == tcNo);
        }

        public void UpdateWithCsAdress(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), new ValidationContext<object>(customer));
            _customerDal.UpdateWithCsAdress(customer);
        }
    }
}
