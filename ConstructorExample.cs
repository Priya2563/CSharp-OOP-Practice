namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee("priya","hrg2",5);
            emp1.Showdetails();
            emp2.Showdetails();
            }
        
    }
        public class Employee
        {
            public string Name;
        public string Department;
        public int salary;
        public Employee() {
            Name = " not assign";
            Department = "hr";
            salary = 0;
        }
        public Employee(string name, string dept,int sal)

        {
            Name = name;
            Department = dept;
            salary = sal;

        }


        
        public void Showdetails()
        {
            Console.WriteLine($"Name:{Name},Department:{Department},salary:{salary}");
        }
        }

     


    }

