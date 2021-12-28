using BankApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.WindowsFormsUI
{
    public class StaticCustomer
    {
        public static Customer GlobalCustomer { get; set; }
    }
}
