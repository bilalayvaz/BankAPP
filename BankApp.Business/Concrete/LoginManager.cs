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
    public class LoginManager : ILoginService
    {
        private ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public void Add(Login login)
        {
            _loginDal.Add(login);
        }

        public List<Login> CheckLoginDetails(string tcNo, string password)
        {
            return _loginDal.GetAll(l => l.TcNo == tcNo && l.Password == password);
        }

        public List<Login> CheckLoginTcNo(string tcNo)
        {
            return _loginDal.GetAll(l => l.TcNo == tcNo);
        }

        public void Delete(Login login)
        {
            _loginDal.Delete(login);
        }

        public List<Login> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Login login)
        {
            _loginDal.Update(login);
        }
    }
}
