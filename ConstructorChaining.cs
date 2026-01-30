namespace ConstructorChaining
{
    //constructor chaining  inheritance with base keyword

    class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Parent Constructor called for Name: {name}");
        }
    }
    class Employeeee : Person
    {
        public int Salary;
        public Employeeee(string name, int salary) : base(name)
        {
            Console.WriteLine($" ChildConstructor called for salary : {salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employeeee empp = new Employeeee("Arpit", 10000);

        }
    }
}

