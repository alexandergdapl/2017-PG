using System;
using System.Collections.Generic;

namespace ConsoleApplication18
{
    public class Service
    {
        readonly List<Person> customers = new List<Person>();

        
        public void GenerateListOfPerson()
        {
            customers.Add(new Person(1, "Mariusz", 18, "555888555"));
            customers.Add(new Person(2, "Dariusz", 28, "111000999"));
            customers.Add(new Person(6, "Zbigniew", 27, "888555888"));
            customers.Add(new Person(3, "Adam", 20, "333666999"));
            customers.Add(new Person(4, "Olek", 19, "222555888"));
            customers.Add(new Person(5, "Ewa", 25, "888555888"));
        }

        public void SortName()
        {
            customers.Sort(delegate (Person x, Person y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });
        }


        public void SortId()
        {
            customers.Sort((x, y) => x.Id.CompareTo(y.Id));
        }


        public void SortAge()
        {
            customers.Sort((x, y) => x.Age.CompareTo(y.Age));
        }


        public void DrukujListe()
        {
            foreach (var q in customers)
            {
                Console.WriteLine($"{q.Id}    {q.Name}    {q.Age}    {q.AccountNumber}");
            }
        }
    }
}
