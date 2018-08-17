using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory
{
    class UserRepository
    {
        public User CreateUser(User user)
        {
            using (var context = new DatabaseContext())
            {
                user.id = Guid.NewGuid();
                context.Users.Add(user);
                context.SaveChanges();
                return context.Users.Find(user.id);
            }
        }

        public List<User> GetListUser()
        {
            using (var context = new DatabaseContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
