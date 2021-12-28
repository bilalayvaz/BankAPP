using BankApp.Business.Abstract;
using BankApp.DataAccess.Abstract;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Concrete
{
    public class CsAccountManager : ICsAccountService
    {
        private ICsAccountDal _csAccountDal;

        public CsAccountManager(ICsAccountDal csAccountDal)
        {
            _csAccountDal = csAccountDal;
        }

        public void Add(CsAccount csAccount)
        {
            _csAccountDal.Add(csAccount);
        }

        public void Delete(CsAccount csAccount)
        {
            _csAccountDal.Delete(csAccount);
        }

        public List<CsAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public CsAccount GetEnableCustomerAccountByAdditionalNumberandCustomerId(int customerId ,int additionalNumber)
        {
            return _csAccountDal.Get(c=>c.CustomerId == customerId && c.AdditionalNumber == additionalNumber && c.AccountState);
        }

        public CsAccount GetCustomerAccountById(int csAccountId)
        {
            return _csAccountDal.Get(c=>c.Id == csAccountId);
        }

        public List<CsAccount> GetEnabledCustomerAccountsWithCustomerId(int customerId)
        {
            return _csAccountDal.GetAll(c => c.AccountState && c.CustomerId == customerId);
        }

        public void Update(CsAccount csAccount)
        {
            _csAccountDal.Update(csAccount);
        }
    }
}
