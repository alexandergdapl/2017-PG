using System;
using System.Collections.Generic;

namespace Osoba
{
    public class PersonContainer
    {
        public List<Person> ListOfPersons = new List<Person>();

        private void GeneratePerson()
        {
            Person newPerson = new Person(55, 157, "Anna", "Jarzębowska", "a@wp.pl");
            ListOfPersons.Add(newPerson);
            newPerson = new Person(11, 188, "Dawid", "Błażejewski", "celina@onet.pl");
            ListOfPersons.Add(newPerson);
            newPerson = new Person(28, 192, "Marek", "Dutkiewicz");
            ListOfPersons.Add(newPerson);
            newPerson = new Person(20, 175, "Barbara", "Różalska");
            ListOfPersons.Add(newPerson);
            newPerson = new Person(42, 172, "Agnieszka", "Warzecha");
            ListOfPersons.Add(newPerson);
            newPerson = new Person(41, 185, "Franciszka", "Zawadzka", "frania@pani.pl");
            ListOfPersons.Add(newPerson);
            newPerson = new Person(30, 177, "Zygmunt", "Adamowicz", "kolega@sześć.pl");
            ListOfPersons.Add(newPerson);
            /*
            Console.WriteLine("Podaj wiek, wzrost i imię.\n" +
                              "Potwierdź dane klikając ENTER.\n");
            do
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("wiek: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("wzrost: ");
                int growth = int.Parse(Console.ReadLine());
                Console.Write("imię: ");
                string name = Console.ReadLine();

                Console.Clear();

                Person newPerson = new Person(age, growth, name);
                ListOfPersons.Add(newPerson);

                Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować.\n" +
                                  "Aby zakończyć wprowadzanie-naciśnij 'n'\n");
                Console.ForegroundColor = ConsoleColor.Black;
            } while (Console.ReadKey().KeyChar != 'n');

            Console.Clear();
            Console.ResetColor();
            */

            //newPerson = new Person(20, 175, "Marek");
            //ListOfPersons.Add(newPerson);
        }

        //todo może jakaś metoda sprawdzająca wiek?

        public PersonContainer()
        {
            GeneratePerson();
        }

        public void IleNaLiscie()
        {
            Console.WriteLine($"Pozycji na liście: {ListOfPersons.Count}");
            Console.WriteLine("Oto lista osób:");
        }

        public void WriteAllPersons()
        {
            IleNaLiscie();
            foreach (var pozycje in ListOfPersons)
            {
                Console.WriteLine($"pozycja: {ListOfPersons.IndexOf(pozycje) + 1}, " +
                                  $"wiek: {pozycje.Age}, " +
                                  $"wzrost: {pozycje.Growth}, " +
                                  $"imię: {pozycje.Name}, " +
                                  $"nazwisko: {pozycje.LastName}, " +
                                  $"email: {pozycje.Email}");
            }
        }

        public void SortowanieAge()
        {
            ListOfPersons.Sort(delegate (Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            });
        }

        public void SortowanieGrowth()
        {
            ListOfPersons.Sort(delegate (Person x, Person y)
            {
                return x.Growth.CompareTo(y.Growth);
            });
        }

        public void SortowanieName()
        {
            ListOfPersons.Sort(delegate (Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            });
        }

        public void SortowanieLastName()
        {
            ListOfPersons.Sort(delegate (Person x, Person y)
            {
                return x.LastName.CompareTo(y.LastName);
            });
        }

        public void BrakMaila()
        {
            Console.WriteLine("maila niet");
        }

        public void SortowanieEmailAscending()
        {
            ListOfPersons.Sort(delegate (Person x, Person y)
            {
                if (x.Email == null && y.Email == null) return 0;
                else if (x.Email == null) return -1;
                else if (y.Email == null) return 1;
                return x.Email.CompareTo(y.Email);
            });
        }

        public void SortowanieEmailDescending()
        {
            ListOfPersons.Sort(delegate (Person x, Person y)
            {
                if (x.Email == null && y.Email == null) return 0;
                else if (x.Email == null) return 1;
                else if (y.Email == null) return -1;
                return x.Email.CompareTo(y.Email);
            });
        }

        private void Wybierz()
        {
            Console.WriteLine("\nSortowanie wg:\n" +
                              "1 - wiek\n" +
                              "2 - wzrost\n" +
                              "3 - imię\n" +
                              "4 - Nazwisko\n" +
                              "5 - e-mail po pustych\n" +
                              "6 - e-mail przed pustymi\n");
        }

        public void Sortowanie()
        {
            //do
            //{
            Wybierz();

            int sortowanko = int.Parse(Console.ReadLine());

            switch (sortowanko)
            {
                case 1:
                    SortowanieAge();
                    break;

                case 2:
                    SortowanieGrowth();
                    break;
            }
            /*
            if (sortowanko == 1)
                SortowanieAge();

            if (sortowanko == 2)
                SortowanieGrowth();
            */

            if (sortowanko == 3)
                SortowanieName();

            if (sortowanko == 4)
                SortowanieLastName();

            if (sortowanko == 5)
                SortowanieEmailAscending();

            if (sortowanko == 6)
                SortowanieEmailDescending();



            //    Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować.\n" +
            //                      "Aby zakończyć sortowanie-naciśnij 'n'\n");

            //} while (Console.ReadKey().KeyChar != 'n');






            //if (x.Name == null && y.Name == null) return 0;
            //else if (x.Name == null) return -1;
            //else if (y.Name == null) return 1;
            //else return x.Name.CompareTo(y.Name);


        }
    }
}
