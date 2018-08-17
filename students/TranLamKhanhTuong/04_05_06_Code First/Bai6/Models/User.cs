using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public Guid id { get; set; }

        public Guid roleId { get; set; }


        [Required]
        [StringLength(50)]
        [Index("IX_username", IsUnique = true)]
        public string username { get; set; }

        public string password { get; set; }

        [ForeignKey("roleId")]
        public virtual Role role { get; set; }
    }
}
