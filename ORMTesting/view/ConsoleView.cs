using ORMTesting.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting.view
{
    public class ConsoleView
    {
        public void printUserList(List<User> users)
        {
            Console.WriteLine("Users list:");
            foreach (User u in users)
            {
                Console.WriteLine(u.ToString());
            }
            Console.WriteLine();
        }

        public void printUser(User user)
        {
            Console.WriteLine(user.ToString());
        }
    }
}
