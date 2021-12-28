using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.Abstract
{
    public interface ICsAdressService
    {
        
        void Add(CsAdress csAdress);
        void Update(CsAdress csAdress);
        void Delete(CsAdress csAdress);
    }
}
