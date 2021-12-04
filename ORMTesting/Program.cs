using ORMTesting.model;
using ORMTesting.repository;
using ORMTesting.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            ConsoleView view = new ConsoleView();

            User user1 = new User("Tom", 33);
            User user2 = new User("Alice", 26);

            userRepository.addAll(user1, user2);

            Console.WriteLine("\nAfter initial adding\n");
            view.printUserList(userRepository.findAll());

            Console.WriteLine("\nAfter adding\n");
            User simon = new User("Simon", 21);
            userRepository.addUser(simon);
            view.printUserList(userRepository.findAll());

            Console.WriteLine("\nFind user with id = 3\n");
            User fromDB = userRepository.findById(3);
            view.printUser(fromDB);

            Console.WriteLine("\nChanging age of user\n");
            fromDB.Age = 54;
            userRepository.updateUser(fromDB);
            view.printUser(fromDB);

            Console.WriteLine("\nAfter deleting\n");
            userRepository.deleteUser(fromDB);
            view.printUserList(userRepository.findAll());
        }        
    }
}
