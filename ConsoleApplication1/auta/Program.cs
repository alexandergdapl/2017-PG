using System;
using System.Collections.Generic;

namespace auta
{
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
}
