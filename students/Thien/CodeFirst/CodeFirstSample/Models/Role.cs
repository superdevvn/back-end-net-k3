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
        //guid uuid: dam bao id khong bi trung
        public Guid Id { get; set; }

        [Index("IX_Code", IsUnique =true)]
        [StringLength(15)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]  //attribute for property
        public string Description { get; set; }

        public bool isActive { get; set; }

    }
}
