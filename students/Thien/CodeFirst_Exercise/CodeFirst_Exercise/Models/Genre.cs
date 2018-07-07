using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(30, MinimumLength =2)]
        [Required]
        public string Economics { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Comic { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Literature { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Journal { get; set; }
    }
}
