using BankApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BankApp.Entities.Concrete
{
    public class CsAccount:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AdditionalNumber { get; set; }
        public int Balance { get; set; }
        public bool AccountState { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
