using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models.Common
{
    public class SampleDbContext: DbContext
    {

        //xac dinh bang Role se phat sinh code
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public SampleDbContext(): base("Data Source=THIEN-PC;Initial Catalog=SimpleCodeFirst;Integrated Security=True")
        { }


    }
}
