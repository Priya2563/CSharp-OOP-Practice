namespace InterfacePractice
{
    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();
    }
    public interface IReachergeable
    {
        public int BatteryPercentage { get; set; }
        public void Charge();

    }
    public interface ISmartFeature
    {
        public void ConnectWiFi(string wifiName);
        public void VoiceAssistant(string command);
    }
    public class Smartphone : IDevice, IReachergeable, ISmartFeature
    {
        public string Model { get; set; }
        public int BatteryPercentage { get; set; }
        public void TurnOn()
        {
            Console.WriteLine($" Smartphone model  is : {Model}");
            Console.WriteLine($"SmartPhone is turning on");
        }
        public void TurnOff()
        {
            Console.WriteLine($"SmartPhone is turning off");
        }
        public void Charge()
        {

            Console.WriteLine($"SmartPhone is charged with {BatteryPercentage} %");
        }
        public void ConnectWiFi(string wifiName)
        {
            Console.WriteLine($"SmartPhone is  connected with {wifiName} wifi");
        }
        public void VoiceAssistant(string command)
        {
            Console.WriteLine($"Smartphone Executing command:{command}");
        }

    }
    public class Laptop : IDevice, IReachergeable
    {
        public string Brand { get; set; }
        public int BatteryPercentage { get; set; }
        public void TurnOn()
        {
            Console.WriteLine($" laptop brand is : {Brand}");
            Console.WriteLine($"Laptop is turning on....");
        }
        public void TurnOff()
        {
            Console.WriteLine($"Laptop is turning off....");
        }
        public void Charge()
        {
            Console.WriteLine($"Laptop is charged with {BatteryPercentage} %....");

        }
    }
    public class SmartWatch : IDevice, ISmartFeature
    {
        public string Series { get; set; }
      
        public int BatteryPercentage { get; set; }
        public void TurnOn()
        {
            Console.WriteLine($" SmartWatch series is : {Series}");
            Console.WriteLine($"Smartwatch is turning on....");
        }
        public void TurnOff()
        {
            Console.WriteLine($"Smartwatch is turning off....");
        }
        public void ConnectWiFi(string wifiName)
        {
            Console.WriteLine($"Smartwatch is connectd with {wifiName} wifi....");
        }
        public void VoiceAssistant(string command)
        {
            Console.WriteLine($"Smartwatch is executed with command {command}....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice[] Devices = new IDevice[]
            {
                new Smartphone { Model = "apple", BatteryPercentage = 50 },
                new Laptop{Brand="unknown", BatteryPercentage=60},
                new SmartWatch{Series = "seriesName",BatteryPercentage=70}
            };
            foreach (var d in Devices)
            {
                d.TurnOn();
                d.TurnOff();
                if(d is IReachergeable chargeable)
                {
                    chargeable.Charge();
                }
                if(d is ISmartFeature feature){
                    feature.ConnectWiFi("priya ki wifi");
                    feature.VoiceAssistant("VolumeUP");
                }
                Console.WriteLine("");
            }
        }

    }
}

