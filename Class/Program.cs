using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(50,DateTime.Now, 20);
            Book book = new Book("Victor Huqo", "Dram",55,DateTime.Now,10);
            Newspaper newspaper = new Newspaper("Display", "Azerbaijan", 10, DateTime.Today, 15);
            //newspaper.newspaperMethod();
            //book.bookMethod();
            //book.sameProduct();
            //newspaper.sameProduct();
            book.Sell();
            newspaper.Sell();
        }
    }
}
