using System;

namespace Osoba
{
    public class Person
    {
        public int Age { get; private set; }
        public int Growth { get; private set; }
        public string Name { get; set; }
        public string LastName { get; private set; }
        public string Email { get; set; }

        public Person(int age, int growth, string name, string lastName)
        {
            this.Age = age;
            this.Growth = growth;
            this.Name = name;
            LastName = lastName;
        }


        public Person(int age, int growth, string name, string lastName, string email)
        {
            this.Age = age;
            this.Growth = growth;
            this.Name = name;
            LastName = lastName;
            Email = email;
        }

        

        

        

        public void SetAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Musisz być penołnoletni");
            }
            if (age == Age)
            {
                return;
            }
            Age = age;
        }
    }
}
