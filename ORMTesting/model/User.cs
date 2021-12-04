using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting.model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Age}";
        }
    }
}
