using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Employee
    {
        private string name;
        private double salary;
        //public void input(string name,double salary)
        //{
        //    this.name = name;
        //    this.salary = salary;
 
        //}
        public Employee()
        {
            name = "";
            salary = 0.0;
        }
        public Employee(string name, double salary)
        
        {
            this.name = name;
            this.salary=salary;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public void print()
        { Console.WriteLine(name+"\n"+salary+"\n"); }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Gamal",55330.636);
            Employee e1 = new Employee("Samer",3000.98);
            e.print();
            e1.print();
           // Employee e3 = new Employee();
           // e3.input("ddss", 865.97);
           // e3.print();
            //Console.WriteLine(e1.Name);
        }
    }
}
