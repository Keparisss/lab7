using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.lab7.Models
{
    public class Purchase
    {
        [Required]
        public int Id { get; set; }
  
        public string Client { get; set; }

        public string Adress { get; set; }
        [Required]
        public int BookId { get; set; }

        public DateTime Date { get; set; }

        //public virtual Book Book { get; set; }
    }
}
