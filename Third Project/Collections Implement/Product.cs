using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Collections_Implement
{
    public class Product:IComparable
    {
        private int price;
        private string name;
        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            Product p=(Product)obj;
            if(this.price < p.price)
            {
                return -1;
            }
            else if(this.price > p.price) { return 1; }
            else { return 0; }

        }
        public override string ToString()
        {
            return $"{price}-{name}";
        }
    }
    public class RunProduct
    {
        static void Main(string[] args)
        {
            Product Fan = new Product(5000,"Fan");
            Product Laptop = new Product(70000, "Laptop");
           int result= Fan.CompareTo(Laptop);
            if (result == 1)
            {
                Console.WriteLine("Price of Laptop is less than Fan");
            }
            if(result == -1)
            {
                Console.WriteLine("Price of Laptop more than Fan");
                
            }
            if(result == 0)
            {
                Console.WriteLine("Both Fan and Laptop has same Price");
            }
        }
    }
}
