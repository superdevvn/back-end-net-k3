using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Producer
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, MinimumLength =3)]
        public string ProducerName { get; set; }

        [Range(0,100)]
        public int numberOfProduct { get; set; }
    }
}
