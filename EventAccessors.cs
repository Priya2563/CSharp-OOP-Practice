namespace EventAccessors
{
    /*
   // 1st practice question on Event accessor
    public class Login
    {
        private event Action _handler;
        private int Count = 0;
        public event Action OnAlert
        {
            add
            { if (Count >= 2) {
                    Console.WriteLine("Subscriber limit reached !");
                    return;
                }
               

                _handler += value;
                Count++;
                Console.WriteLine("Subscriber Added");
            }
            remove
            {
                _handler -= value;
                Count--;
                Console.WriteLine("Subscriber removed");
            }
        }
        public void Fired()
        {
            _handler?.Invoke();
        }
    }
    // 2nd question 
    public class LimitedPublisher
    {
        private event Action _handler;
        private int Count = 0;
        public event Action OnNotify
        {
            add
            {
                if (Count >= 2)
                {
                    Console.WriteLine("Subscriber limit reached !");
                    return;

                }
                _handler += value;

                Console.WriteLine($" subscriber added");
                Count++;
            }
            remove
            {
                _handler -= value;
                Console.WriteLine("Subscriber removed");
                Count--;
                Console.WriteLine($"{Count}");
            }
        }
            public void fired()
        {
            _handler?.Invoke();
        }
        }
    */
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // 1st question ka main program
            Login log = new Login();
            log.OnAlert += () => { Console.WriteLine("Handler1 added"); };
          log.OnAlert += () => { Console.WriteLine("Handler2 are added"); };
            log.OnAlert += () => { Console.WriteLine("Handler3 are added"); }; log.OnAlert += () => { Console.WriteLine("Handler4 are added"); };
            log.Fired(); 

            //2nd question ka main program
            LimitedPublisher Lpub = new LimitedPublisher();
            Action h1 = () => { Console.WriteLine("Handler1 Executed");};
            Action h2= () => { Console.WriteLine("Handler2 Executed"); };
            Action h3= () => { Console.WriteLine("Handler3 Executed"); };

            Lpub.OnNotify += h1;
            Lpub.OnNotify += h2;
            Lpub.OnNotify += h3;
            Lpub.OnNotify -= h1;
            Lpub.fired();*/
        }

        }
}

