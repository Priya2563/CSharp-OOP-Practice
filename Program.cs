namespace Home_Automation_System_UsingOverride
{
    class SmartDevice
    {
        public string Brand { get; set; }
        public string Price { get; set; }
        public virtual void TurnOn() {
            Console.WriteLine($"Smart device is turning on");
        }

    }
    class SmartBulb : SmartDevice
    {
        public int Watt { get; set; }
        public override void TurnOn()
        {
            Console.WriteLine($"Smart Bulb is turning on with brightness!");
        }
        public void ChangeColor()
        {
            Console.WriteLine($"Bulb color changed");
        }
    }
    class SmartTV : SmartDevice
    {
        public int ScreenSize { get; set; }
        public override void TurnOn()
        {
            Console.WriteLine($"Smart tv is turning on with display");
        }
        public void PlayNetflix()
        {
            Console.WriteLine($"Netflix is now playing");
        }
    }
   class SmartSpeaker : SmartDevice{
        public int VolumeLevel { get; set; }

        public override void TurnOn()
        {
            Console.WriteLine($"Smart Speaker is turning on with sound!");
        }
        public void PlayMusic()
        {
            Console.WriteLine($"Playing music!");
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
             SmartDevice[] devices = new SmartDevice[]
                 {
                 new SmartBulb(),
                 new SmartTV(),
                new SmartSpeaker()
                 };
             foreach (var device in devices)
             {
                 device.TurnOn();

             }
             
        }
    }
}
