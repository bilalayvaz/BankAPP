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
    public class CsAdress:IEntity
    {
        
        public int Id { get; set; }       
        public int CustomerId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        
        [Required]
        public virtual Customer Customer { get; set; }
        
    }
}
