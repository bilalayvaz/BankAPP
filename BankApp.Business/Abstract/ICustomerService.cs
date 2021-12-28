using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetCustomerByCustomerId(int customerId);
        Customer GetCustomerByCustomerNo(int customerNo);
        List<Customer> GetCustomerByTcNo(string tcNO);
        List<Customer> GetCustomerWithOthersByCustomerId(int customerId);
        List<Customer> GetCustomerWithOthersByCustomerTcNo(string tcNo);
       // List<Customer> GetEnabledCustomerAccountsWithCustomerId(int customerId);



        int GetRandomUniqueCustomerNo();
        void Add(Customer customer);
        void Update(Customer customer);
        void UpdateWithCsAdress(Customer customer);
        void Delete(Customer customer);
    }
}
