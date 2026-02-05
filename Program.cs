namespace TransactionProcessingSystemUsingDelegate
{
    public delegate void TransactionHandler(decimal amount);
    public class Bank
    {
        public void Debit(decimal amount)
        {
            Console.WriteLine("Debiting amount : " + amount);

        }
        public void Credit(decimal amount)
        {
            Console.WriteLine("Crediting amount : " + amount);
        }
    }
    public class Notification
    {
        public void SendSMS(decimal amount)
        {
            Console.WriteLine("SMS : Transaction of " + amount + " is completed ");
        }
        public void SendEmail(decimal amount)
        {
            Console.WriteLine("Email : Transaction of " + amount + "Completed");
        }
    }
    public class Logger
    {
        public void Log(decimal amount)
        {
            Console.WriteLine("Log saved for Amount " + amount);
        }
    }
    public class TransactionProcessor
    {
        public TransactionHandler ProcessTransaction;
        public void Execute(decimal amount)
        {
            if (ProcessTransaction != null)
            {
                ProcessTransaction(amount);
                Console.WriteLine("All Transaction handlers executed successfully !");
            }
            else
            {
                Console.WriteLine("No handlers attached !");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Notification notification = new Notification();
            Logger logger = new Logger();
            TransactionProcessor tp = new TransactionProcessor();
            tp.ProcessTransaction += bank.Debit;
            tp.ProcessTransaction += bank.Credit;
            tp.ProcessTransaction += notification.SendSMS;
            tp.ProcessTransaction += notification.SendEmail;
            tp.ProcessTransaction += logger.Log;
            tp.ProcessTransaction += (amount) =>
            {
                Console.WriteLine("Anonymous Processing amount " + amount);
            };
            tp.Execute(5000);

            

        }
    }
}
