using BankApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BankApp.Entities.Concrete
{
    public class Login : IEntity
    {
        [Key]
        public int Id { get; set; }       
        public string TcNo { get; set; }
        public string Password { get; set; }

        public int CustomerId { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }

    }
}
