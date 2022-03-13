using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Book:Product
    {
        public string Author;
        public string Genre;

        public Book(string author, string genre, int price, DateTime relaisedate, int count):base(price,relaisedate,count)
        {
            Author = author;
            Genre = genre;
        }
        public void bookMethod()
        {
            Console.WriteLine($"Author: {Author} Genre: {Genre}");
        }
        
    }
}
