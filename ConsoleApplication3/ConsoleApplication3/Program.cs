using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        private string name;
        private int num;
        private string section;
        public void input(string name, int num, string section)
        {
            this.name = name;
            this.num = num;
            this.section = section;
        }
        public void print()
        { Console.WriteLine("name: "+name + "\n" +"num: "+num + "\n" +"section: "+section+"\n"+"\n"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.input("Abdulah",2041,"Tcc");
            s.print();
            Student s1 = new Student();
            s1.input("Amr",3536,"Tcc");
            s1.print();


        }
    }
}
