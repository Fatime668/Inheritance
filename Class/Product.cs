using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Product
    {
        public int Price;
        public DateTime RelaiseDate;
        public int Count;
        public void sameProduct()
        {
                Console.WriteLine($"Price: {Price} RelaiseDate: {RelaiseDate} Count: {Count}");
        }
        public void Sell()
        {
            int num = 0;
            if (Count !=0)
            {
                for (int i = 0; i < Count - 1; i++)
                {
                    num++;
                    
                }
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Mehsul tapilmadi");
            }
        }
        public Product(int price, DateTime relaisedate, int count)
        {
            Price = price;
            RelaiseDate = relaisedate;
            Count = count;
        }
        
    }
}
