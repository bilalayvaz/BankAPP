using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Abstract
{
    public interface ICsAccountService
    {
        List<CsAccount> GetAll();
        List<CsAccount> GetEnabledCustomerAccountsWithCustomerId(int customerId);
        CsAccount GetCustomerAccountById(int csAccountId);
        CsAccount GetEnableCustomerAccountByAdditionalNumberandCustomerId(int customerId, int additionalNumber);
        void Add(CsAccount csAccount);
        void Update(CsAccount csAccount);
        void Delete(CsAccount csAccount);
    }
}
