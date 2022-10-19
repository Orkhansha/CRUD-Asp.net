using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Models
{
    public class Social : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
