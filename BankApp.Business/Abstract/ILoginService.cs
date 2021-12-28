using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Abstract
{
    public interface ILoginService
    {
        List<Login> GetAll();
        List<Login> CheckLoginDetails(string tcNo , string password);
        List<Login> CheckLoginTcNo(string tcNo);
        void Add(Login login);
        void Update(Login login);
        void Delete(Login login);
    }
}
