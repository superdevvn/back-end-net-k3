using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    class PurchaseHistory
    {
        [Key]
        public Guid Id { get; set; }

        public Guid IdPay { get; set; }

        [ForeignKey("IdPay")]
        public virtual Pay Pay { get; set; }
    }
}
