using System;
using System.Collections.Generic;

namespace newTestProject
{
    class Program
    {
        static void Main()
        {


            List<Car> cars = new List<Car>();

            cars.Add(new Car("mega tachka"));
            cars.Add(new Car("tachana"));
            cars.Add(new Car("ssanina"));
            cars.Add(new Car("rewrew tachka"));
            cars.Add(new Car("hyu znaet tachka"));
            cars.Add(new Car("pohyu tachka"));

            nextLevelCar cars2 = new nextLevelCar();

            cars2.Name = "mewrewrewrew";
            cars2.NextLevelClassName = "FORMULA 1";

            foreach (Car obj in cars)
            {
                obj.printAllVaues();

            }

            cars2.printAllVaues();

            Console.WriteLine(cars[0] is object);





        }
    }
}
