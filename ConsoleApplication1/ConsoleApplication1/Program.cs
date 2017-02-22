using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//rozwiazanie zadania+kod przykladowy z zajec, w kodzie umieszczone sa 
//elementy, których jeszcze nie omawialismy(przy funkcjach sortujących i jedna 
//metoda nadpisująca działanie tostring, z przykładowego kodu->zakomentowany kod), 
//na to nie patrzcie

namespace ConsoleApplication1
{
	class Program
	{
		static void Main()
		{
		PersonContainer Persons = new PersonContainer();
		
		Persons.SortByName();
	
		}
	}

	class PersonContainer
	{
	public List<Person>ListOfPersons; 
	public PersonContainer()
	{
	ListOfPersons = new List<Person>();
	GeneratePersonList();
	}
	private void GeneratePersonList()
	{
		Person NewPerson = new Person("Seba","Wolski",16,180);
		ListOfPersons.Add(NewPerson);
		NewPerson = new Person("Janusz","Tracz",44,185);
		ListOfPersons.Add(NewPerson);
	}
	public void SortByName()
	{
		List<Person> SortedList = ListOfPersons.OrderBy(Osoba=>Osoba.Name).ToList();
		ListOfPersons = SortedList;
	}

	}

	class Person
	{
		public string Name;
		public string Surname;
		public int Age;
		public int Height;
		public Person(string name,string surname,int age, int height)
		{
			Name =name;
			Surname = surname;
			Age = age;
			Height = height;

		}
	}

/*
	class Program
	{
		static void Main(string[] args)
		{
		
		CarContainer Cars = new CarContainer();
		Cars.WriteAllCars();
		}
	}

	class CarContainer
	{
		public CarContainer()
		{
			GenerateCars();
		}

		public List<Car>ListOfCars = new List<Car>();

		private void GenerateCars()
		{
		Car NewCar = new Car("Porshe 911",1768,200);
		ListOfCars.Add(NewCar);
		NewCar = new Car("Audi A6",1450,150);
		ListOfCars.Add(NewCar);
		
		}

		public void WriteAllCars()
		{
			foreach (Car item in ListOfCars)
			{
				Console.WriteLine(item.ToString());
			}
		}
	}

	class Car
	{

		public string Model;
		public int Mass;
		public int MaximumSpeed;

		public Car(string model, int mass,int maximumSpeed)
		{
			Model = model;
			Mass = mass;
			MaximumSpeed= maximumSpeed;
		}
		public override string ToString()
		{
			return Model+" "+Mass.ToString()+" "
			+ MaximumSpeed.ToString();
		}
	}
 * */
}
