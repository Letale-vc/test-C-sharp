using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace newTestProject{    class Car    {        public static int countCar;        private string name;

        public void setValues(string name)
        {
            this.name = name;
            Console.WriteLine("\nCreate car: {0}\n", this.name);
            countCar++;
        }

        public Car(string name)
        {
            this.name = name;
            Console.WriteLine("\nCreate car: {0}\n", this.name);
            countCar++;

        }
        public virtual void printAllVaues()
        {
            Console.WriteLine("\nName: {0}\n", this.name);


        }

        public Car() { }

        public string Name
        {
            get
            {

                return this.name;
            }
            set
            {
                this.name = value;
                countCar++;
                Console.WriteLine("\nCreate car: {0}\n", this.name);
            }
        }


    }}