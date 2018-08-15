using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory
{
    class RoleRepository
    {
        public Role CreateRole(Role role)
        {
            using (var context = new DatabaseContext())
            {
                role.id = Guid.NewGuid();
                context.Roles.Add(role);
                context.SaveChanges();
                return context.Roles.Find(role.id);
            }
        }

        public List<Role> GetListRole()
        {
            using (var context = new DatabaseContext())
            {
                return context.Roles.ToList();
            }
        }
    }
}
