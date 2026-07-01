using System;

namespace DeveloperComeback.Models
{
    // abstract class means I cannot do the following: var person = new Person("John", 30);
    // It will act as the base where the other classes can derive from it, but I cannot create an instance of it directly.
    public abstract class Person
    {
        public string Name { get; }
        public int Age { get; }

        // Constructor: This is used to create a new instance of the Person class. It takes two parameters: name and age.
        // Instead of creating a Person with no details, and then afterwards setting the name and age, we can use this constructor to ensure that a Person is always created with valid details.
        // This is a common practice in object-oriented programming to ensure that objects are always in a valid state.
        protected Person(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            if (age < 18)
                throw new ArgumentOutOfRangeException(nameof(age), "Age must be 18 or older.");

            Name = name;
            Age = age;
        }

        // virtual is necessary in order to allow derived classes to override this method. If we don't use virtual, the derived classes cannot override this method.
        public virtual string GetDescription()
        {
            return $"{Name} ({Age})";
        }
    }
}
