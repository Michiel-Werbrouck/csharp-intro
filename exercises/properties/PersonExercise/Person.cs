using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get { return Name; } set { if (value?.Length == 0) throw new ArgumentException("Name can't be empty"); } }
        public int Age { get { return Age; } set { if (Age < 0) throw new ArgumentException("Age must be positive"); } }
    }
}
