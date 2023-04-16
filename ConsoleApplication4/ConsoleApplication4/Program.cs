using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Book
    {
        private string name;
        private double price;
        public void input(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public void print()
        { Console.WriteLine(name + "\n" + price); }
        public double discount()
        { return (price - (price * 10 / 100)); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b=new Book();
            b.input("Efs",6089.867);
            b.print();
            Console.WriteLine(b.discount());
        }
    }
}
