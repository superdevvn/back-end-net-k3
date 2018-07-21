using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    class Pay
    {
        [Key]
        public Guid Id { get; set; }

        public Guid IdCustomer { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0: MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

    }
}
