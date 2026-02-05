namespace CustomEventArgs_Practice
{
   
    public class TemperatureEventArgs : EventArgs {
    public int CurrentTemprature { get; set; }
        public TemperatureEventArgs(int temp)
        {
            CurrentTemprature = temp;
        }
    }
    class TemperatureSensor
    {
        

        public event EventHandler<TemperatureEventArgs> OnTempratureChanged;
        private int temperature;
        public void SetTemperature(int temp)
        {
            temperature = temp;
            Console.WriteLine($"Temperature changed to {temperature}");
            OnTempratureChanged?.Invoke(this, new TemperatureEventArgs(temperature));
        }

    }

    internal class Program
    {
    
        public static void HandleTemperature(object sender, TemperatureEventArgs e)
        {
            if(e.CurrentTemprature > 40)
            {
                Console.WriteLine($"Warning High Temperature:{e.CurrentTemprature}");


            }
            else
            {
                Console.WriteLine($"Temperature is Normal : {e.CurrentTemprature}");
            }
        }
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.OnTempratureChanged += HandleTemperature;
            sensor.SetTemperature(25);
            sensor.SetTemperature(45);

        }
    }
}

