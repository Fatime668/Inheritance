using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Newspaper:Product
    {
        public string Advertisement;
        public string Article;

        public Newspaper(string advertisement, string article, int price, DateTime relaisedate, int count):base(price, relaisedate,count)
        {
            Advertisement = advertisement;
            Article = article;
        }
        public void newspaperMethod()
        {
            Console.WriteLine($"Advertisement: {Advertisement} Article: {Article}"); 
        }
        
    }
}
