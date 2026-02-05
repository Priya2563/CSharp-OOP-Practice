namespace EventWithDelegates
{
    
    public class Button
    {
        public delegate void Action();
        public event Action OnClick;
        public void Click()
        {
            Console.WriteLine($"Event is started ");
            if (OnClick != null)
            {
                OnClick?.Invoke();
                Console.WriteLine("Event Fired !");
                Console.WriteLine("Button Clicked!");

            }
        }
    }
    class Door
    {
        public delegate void DoorDelegate();
        public event DoorDelegate OnOpen;
        public void Open()
        {
            Console.WriteLine("Door is opening....");
            if (OnOpen != null)
            {
                OnOpen.Invoke();
                
            }
        }
    }
    class machine
    {
        public delegate void start();
        public event start OnStart;

        public void Start()
        {
            Console.WriteLine("Machine Started");
            OnStart?.Invoke();
           
        }
    }
    class Car
    {
        public delegate void CarDelegate();
        public event CarDelegate OnSpeedChanged;
        public void SetSpeed(int s)
        {
            OnSpeedChanged?.Invoke();
        }
    }
    class Mobile
    {
        public delegate void Message();
        public event Message OnReceiveMessage;
        public void Notification()
        {
            OnReceiveMessage?.Invoke();
        }

    }
    internal class Program
    {
        public static void Alarm()
        {
            Console.WriteLine("Alarm Door Opened!");
        }
        public static void Light()
        {
            Console.WriteLine("Light on");
        }

        public static void ShowNotification()
        {
            Console.WriteLine("Show Notification here");
        }


        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.OnReceiveMessage += ShowNotification;
            m.Notification();
           Car car = new Car();
            
          machine M = new machine();
            M.OnStart += () => Console.WriteLine("Listener : Machine has started");
            M.Start();  
            
            Door d = new Door();
            d.OnOpen += Alarm;
            d.OnOpen += Light;
            d.Open();
            
           Button button = new Button();
            button.OnClick += () =>
            {
                Console.WriteLine("Button par click hua");
            };
            button.Click();  

        }
    }
}
