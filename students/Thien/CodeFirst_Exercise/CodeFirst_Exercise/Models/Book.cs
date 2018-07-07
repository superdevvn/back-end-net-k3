using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0 : MM/dd/yyyy}")]
        public DateTime EntryDate { get; set; }


        public int View { get; set; }

        public int Purchases { get; set; }

        [StringLength(100,MinimumLength =2)]
        [Required]
        public string Picture { get; set; }

        
        public Guid IdGenre { get; set; }
        
        public Guid IdProducer { get; set; }

        [ForeignKey("IdGenre")]
        public virtual Genre Genre { get; set; }

        [ForeignKey("IdProducer")]
        public virtual Producer Producer { get; set; }
    }
}
