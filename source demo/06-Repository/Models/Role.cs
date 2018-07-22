using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        [Index("IX_username", IsUnique = true)]
        public string code { get; set; }

        public string name { get; set; }
    }
}
