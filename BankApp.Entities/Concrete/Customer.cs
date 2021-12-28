using BankApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Entities.Concrete
{
    public class Customer:IEntity
    {

        [Key]
        public int Id { get; set; }
        public string TcNo { get; set; }
        public int CustomerNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateTime { get; set; }


        public virtual CsAdress CsAdress { get; set; }
        public virtual Login Login { get; set; }  
        public virtual ICollection<CsAccount> CsAccount { get; set; }

    }
}
