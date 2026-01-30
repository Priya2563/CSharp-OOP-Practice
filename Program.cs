namespace classAndObject
{

    class Student
    {
        public string name;
        public int age;
        public char grade;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {name} , age : {age} , grade : {grade}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "priya";
            s1.age = 23;
            s1.grade = 'A';
            s1.DisplayInfo();
          
        }
    }
}
