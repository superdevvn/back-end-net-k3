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
        // guid uuid
        public Guid Id { get; set; }

        [Index("IX_Code", IsUnique = true)]
        [StringLength(15)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool IsActived { get; set; }

        [StringLength(1000)] // Attribute
        public string Description { get; set; } // Property
    }
}
