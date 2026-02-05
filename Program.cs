using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace NotificationSystemUsingDelegates
{
    /* public delegate void Greet(string Message);  
    public delegate  void Notification(); */
    public delegate void Calculator(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Sum of the a and b is " + (a+b) );
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Substraction of the a and b is " + (a-b) );
        }
        public static void Multiply (int a, int b)
        {
            Console.WriteLine("multiplication  of the a and b is  " + (a * b));
        }
        public static void divide(int a, int b)
        {
            Console.WriteLine("Sum of the a and b is" + (a / b));
        }

        /*
        public static void SendEmail()
        {
            Console.WriteLine("Email is sending");
        }
        public static void SendSMS()
        {
        Console.WriteLine("Messages are sends");
        }
        public static void pushNotification()
        {
            Console.WriteLine("Apps are send notification");

        }
        public  void GreetHindi(string Message)
        {
            Console.WriteLine($"hi priya {Message}");

        }
        public void GreetEnglish(string Message)
        {
            Console.WriteLine($"hi priya {Message}");

        }
        public void GreetMarathi(string Message)
        {
            Console.WriteLine($"Hiiii priya {Message}");
        }
        */
        static void Main(string[] args)
        {
             Calculator calculator = Add;
            calculator += Sub;
            calculator += Multiply;
            calculator += divide;
            calculator(4, 2);

            /* Notification notify = SendEmail;
            notify += SendSMS;
            notify += pushNotification;
            notify();
            Program p = new Program();
            Greet greet = p.GreetHindi;
            greet("Good Namaste");
            greet = p.GreetEnglish;
            greet("Good morning");
            greet = p.GreetMarathi;
            greet("Gm");*/
        }
    }
}
