using System.Diagnostics;
using System.IO.Pipes;
using CopyConstructor;

namespace CopyConstructor
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string[] Reviews { get; set; }
        public Book(string title, string author, decimal price, string[] reviews)
        {
            Title = title;
            Author = author;
            Price = price;
            Reviews = reviews;
        
           
        }
        public Book(Book value)
        {
            this.Title = value.Title;
            this.Author = value.Author;
            this.Price = value.Price;
            this.Reviews = new string[value.Reviews.Length];
            Array.Copy(value.Reviews, Reviews, value.Reviews.Length);
        }

        public void show(string type)
        {
            Console.WriteLine("Duplicate Book : ");
            Console.WriteLine($"Title:{Title}, Author{Author},Price  : {Price}");
            Console.Write($"Reviews: ");
            foreach (var r in Reviews)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Jo tum kaho", "Priya", 500, new string[] { "good", "Bad", "medium" });
        Book b2 = new Book(b1);
        b1.Title = "tum na kaho";
        b2.Author = "Arpit";
        b2.Reviews[0] = "Exellent";
        b1.show("Original Book");
        b2.show("Duplicate Book");
        }
    }

