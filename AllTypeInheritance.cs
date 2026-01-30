namespace AllTypeInheritance
{// Inheritance

 //single inheritance
 //Multilevel inheritance
 // Hierarchical inheritance
 // Multiple Inheritance C# me class allow nahi karta h lekin Intrface ke through allow hai
 //Hybrid Inheritance : Multilevel + hierarchical + Interface 
    class Animal
    {
        public string Name;
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

    }
    class Dog : Animal
    {
        public string Breed;
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    //hierarchical inheritance 
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name of employee is {Name}, Salary is {Salary}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public void WorkFullTime()
        {
            Console.WriteLine($"This employee works full time. Name: {Name}, Salary: {Salary}");
        }
    }

    class PartTimeEmployee : Employee
    {
        public void WorkPartTime()
        {
            Console.WriteLine($"This employee works part time. Name: {Name}, Salary: {Salary}");
        }
    }

    class Intern : Employee
    {
        public void Learn()
        {
            Console.WriteLine($"This employee is an intern. Name: {Name}, Salary: {Salary}");
        }
    }
    //Multilevel inheritance
    class Vehicle
    {
        public string Brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine($"Vehicle brand is {Brand}");
        }
    }

    class Car : Vehicle
    {
        public string Model { get; set; }

        public void ShowModel()
        {
            Console.WriteLine($"Car model is {Model}");
        }
    }

    class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public void ShowBattery()
        {
            Console.WriteLine($"Car battery capacity is {BatteryCapacity} mAh");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //single inheritance

            Dog d1 = new Dog();
            d1.Name = "joya";
            d1.Breed = "German";
            d1.Eat();
            d1.Bark();

            Console.WriteLine($"{d1.Name} Dog is barking {d1.Breed} ");
            // Hierarchical inheritance
            Employee emp = new Employee();
            emp.Name = "Priya";
            emp.Salary = 5;

            FullTimeEmployee emp1 = new FullTimeEmployee();
            emp1.Name = "Arpit";
            emp1.Salary = 4;

            PartTimeEmployee emp2 = new PartTimeEmployee();
            emp2.Name = "Arp";
            emp2.Salary = 3;

            Intern emp3 = new Intern();
            emp3.Name = "Arpit";
            emp3.Salary = 4;

            emp.ShowInfo();
            emp1.WorkFullTime();
            emp2.WorkPartTime();
            emp3.Learn();

            //Multilevel inheritance
            ElectricCar car1 = new ElectricCar();
            car1.Brand = "BMW";
            car1.Model = "i5 Sport";
            car1.BatteryCapacity = 5000;

            car1.ShowBrand();
            car1.ShowModel();
            car1.ShowBattery();
        }
    }
}
