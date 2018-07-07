using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, MinimumLength =3)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public Guid IdPurchaseHistory { get; set; }

        [ForeignKey("IdPurchaseHistory")]
        public virtual PurchaseHistory PurchaseHistory { get; set; }
    }
}
