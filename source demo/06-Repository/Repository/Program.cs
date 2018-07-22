using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateRole();
            //CreateUser();
            GetListUser();
        }

        static void CreateRole()
        {
            var role = new Role();
            Console.Write("Role Code: ");
            role.code = Console.ReadLine();
            Console.Write("Role Name: ");
            role.name = Console.ReadLine();
            var roleRepository = new RoleRepository();
            roleRepository.Create(role);
        }

        static void CreateUser()
        {
            var user = new User();
            Console.Write("RoleId: ");
            user.roleId = new Guid(Console.ReadLine());
            Console.Write("Username: ");
            user.username = Console.ReadLine();
            Console.Write("Password: ");
            user.password = Console.ReadLine();
            var userRepository = new UserRepository();
            userRepository.Create(user);
        }

        static void GetListUser()
        {
            var userRepository = new UserRepository();
            var users = userRepository.GetList();
            foreach(var user in users)
            {
                Console.WriteLine("Username: " + user.GetType().GetProperty("username").GetValue(user, null).ToString());
                Console.WriteLine("Password: " + user.GetType().GetProperty("password").GetValue(user, null).ToString());
                Console.WriteLine("Role Code: " + user.GetType().GetProperty("roleCode").GetValue(user, null).ToString());
                Console.WriteLine("Role Name: " + user.GetType().GetProperty("roleName").GetValue(user, null).ToString());
            }
        }
    }
}
