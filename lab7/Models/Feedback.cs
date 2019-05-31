using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class Feedback
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public string AboutBook { get; set; }

    }
}
