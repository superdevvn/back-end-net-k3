using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDev.Models
{
    public interface IApproved
    {
        DateTime ApprovedDate { get; set; }

        Guid? ApprovedBy { get; set; }

        User Approver { get; set; }
    }
}
