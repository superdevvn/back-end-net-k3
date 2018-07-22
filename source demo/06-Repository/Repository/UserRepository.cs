using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public class UserRepository
    {
        public User Create(User user)
        {
            using (var context = new SuperDevDbContext())
            {
                user.id = Guid.NewGuid();
                context.Users.Add(user);
                context.SaveChanges();
                return context.Users.Find(user.id);
            }
        }

        public IEnumerable GetList()
        {
            using (var context = new SuperDevDbContext())
            {
                return context.Users.Select(e => new
                {
                    id = e.id,
                    username = e.username,
                    password = e.password,
                    roleCode = e.role.code,
                    roleName = e.role.name
                }).ToList();
            }
        }
    }
}
