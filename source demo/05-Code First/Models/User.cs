using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        // guid uuid
        public Guid Id { get; set; }

        public Guid RoleId { get; set; }

        [Index("IX_Code", IsUnique = true)]
        [StringLength(15)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
