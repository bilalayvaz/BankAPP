using BankApp.DataAccess.Abstract;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Concrete.EntityFramework
{
    public class EfCsAccountDal: EfEntityRepositoryBase<CsAccount, BankAppContext>, ICsAccountDal
    {
    }
}
