using ORMTesting.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting.repository
{
    internal class UserRepository
    {

        public List<User> findAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users.ToList();
            }
        }

        public User findById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users
                    .Where(user => user.Id == id)
                    .FirstOrDefault();
            }
        }

        public List<User> findByName(String name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users
                .Where(user => user.Name == name)
                .ToList();
            }
        }

        public List<User> findByAge(int age)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users
                .Where(user => user.Age == age)
                .ToList();
            }
        }

        public List<User> findByAgeInRange(int fromAge, int toAge)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users
                .Where(user => user.Age >= fromAge && user.Age <= toAge)
                .ToList();
            }
        }

        public User addUser(User user)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
        }

        public List<User> addAll(params User[] users)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
                return users.ToList();
            }
        }

        public User deleteUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return user;
            }
        }

        public User updateUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Update(user);
                db.SaveChanges();
                return user;
            }
        }


    }
}
