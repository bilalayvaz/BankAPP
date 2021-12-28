using BankApp.Business.Abstract;
using BankApp.DataAccess.Abstract;
using BankApp.DataAccess.Concrete.EntityFramework;
using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Concrete
{
    public class CsAdressManager:ICsAdressService
    {
        private ICsAdressDal _csAdressDal;

        public CsAdressManager(ICsAdressDal csAdressDal)
        {
            _csAdressDal = csAdressDal;
        }

        public void Add(CsAdress csAdress)
        {
            _csAdressDal.Add(csAdress);
        }

        public void Delete(CsAdress csAdress)
        {
            _csAdressDal.Delete(csAdress);
        }


        public void Update(CsAdress csAdress)
        {
            _csAdressDal.Update(csAdress);
        }
    }
}
