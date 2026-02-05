using System.Security.Cryptography.X509Certificates;

namespace PriceChangeEvent
{
    public class LoginEventArgs : EventArgs
    {
    public string UserName { get; set; }
        public LoginEventArgs(string userName)
        {
            UserName = userName;
        }
     }
    public class ForEvent
    {
        public event EventHandler<LoginEventArgs> OnLogin;
        
        public void Login(string userName)
        {
            Console.WriteLine($"{userName} logged in.");
            OnLogin?.Invoke(this, new LoginEventArgs(userName));
        }
    }
   /* public class StockChangedEventArgs : EventArgs
    {
        public string StockName { get;}
        public decimal OldPrice { get; }
        public decimal NewPrice { get;}
        public decimal ChangePercent { get;}
        public StockChangedEventArgs(string stockName, decimal oldPrice, decimal newPrice)
        {
            StockName = stockName;
            OldPrice = oldPrice;
            NewPrice = newPrice;
            ChangePercent = ((newPrice-oldPrice)/oldPrice) * 100;
        }
    }
    public class Stock
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public event EventHandler<StockChangedEventArgs> OnPriceChanged;
        public void UpdatePrice(decimal newPrice)
        {
            decimal oldPrice = Price;
            Price = newPrice;
            Console.WriteLine($"{Name} price updated to {Price}");
            OnPriceChanged?.Invoke(this, new StockChangedEventArgs(Name, oldPrice, newPrice));
        }
    }*/

    internal class Program
    {
        public static void SubscribeHandle(Object sender,LoginEventArgs e)
        {
            Console.WriteLine($"Welcome {e.UserName}");
        }
       /* public static void HandleStockChanged(Object Sender, StockChangedEventArgs e)
        {
            if (e.ChangePercent > 5)
            {
                Console.WriteLine($"{e.StockName} spiked by {e.ChangePercent:F2} % !");
            }
            else if( e.ChangePercent < - 5){
                Console.WriteLine($"{e.StockName} droped by {e.ChangePercent:F2} %");
            }
            else
            {
                Console.WriteLine($"Normal change :{e.StockName} changed by {e.ChangePercent:F2}%");
            }
        }*/
        static void Main(string[] args)
        {
            ForEvent forEvent = new ForEvent();
            forEvent.OnLogin += SubscribeHandle;
            forEvent.Login("priya");
            /*
            Stock tesla= new Stock() { Name="Tesla",Price = 1000};
            tesla.OnPriceChanged += HandleStockChanged;
            tesla.UpdatePrice(1050);
            tesla.UpdatePrice(900);
            tesla.UpdatePrice(920);*/
    }
} 
}
