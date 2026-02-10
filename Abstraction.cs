

namespace Abstraction
{
    abstract class Payment
    {
        public double Amount { get; set; }
        public string CustomerName { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Customer name is {CustomerName} customer payment amount is {Amount}");
        }

        public abstract void MakePayment();

    }
        class UPI : Payment
    {
        public string UPIid { get; set; }

        public override void MakePayment()
        {
            Console.WriteLine($"processing UPI Payment");
        }
        }
    class CreditCard : Payment
    {
        public string CardNumber { get; set; }
        public override void MakePayment()
        {
            Console.WriteLine($"Processing Credit card payment");
        }
    }
    class DebitCard : Payment
    {
        public string CardNumber { get; set; }
        public override void MakePayment()
        {
            Console.WriteLine($"Processing Debit Card Payment");
        }
    }
    class NetBanking : Payment
    {
        public string BankName { get; set; }
        public override void MakePayment()
        {
            Console.WriteLine($"processing Netbanking payment");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Payment[] payments = new Payment[]
            {
                new UPI{Amount=500,CustomerName="priya",UPIid="123-456-43"},
                new CreditCard{Amount=50,CustomerName="riya",CardNumber="123-456-43"},
                new DebitCard{Amount=100,CustomerName="priya",CardNumber="123-456-43"},
                new NetBanking{Amount=500,CustomerName="priya",BankName="123-456-43"}
            };
           
            foreach (Payment payment in payments)
            {
               
            
                payment.MakePayment();
                payment.ShowDetails();
              
            }
         
           
           
        }
    }
}


