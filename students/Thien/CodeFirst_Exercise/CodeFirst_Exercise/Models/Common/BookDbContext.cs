using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
   public class BookDbContext : DbContext
    {
        DbSet<Producer> producer { get; set; }
        DbSet<Genre> genre { get; set; }
        DbSet<Book> book { get; set; }
        DbSet<Customer> customer { get; set; }
        DbSet<Pay> pay { get; set; }
        DbSet<PurchaseHistory> purchaseHistory { get; set; }
        public BookDbContext(): base("Data Source=THIEN-PC;Initial Catalog=BookOnline;Integrated Security=True")
        { }
    }
}
