using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public class RoleRepository
    {
        public Role Create(Role role)
        {
            using (var context = new SuperDevDbContext())
            {
                role.id = Guid.NewGuid();
                context.Roles.Add(role);
                context.SaveChanges();
                return context.Roles.Find(role.id);
            }
        }

        public List<Role> GetList()
        {
            using (var context = new SuperDevDbContext())
            {
                return context.Roles.ToList();
            }
        }
    }
}
