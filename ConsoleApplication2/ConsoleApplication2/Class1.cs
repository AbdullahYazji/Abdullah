using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Employee
    {
        private string name;
        private int id;
        private double salary;
        public Employee()
        {
            this.name = "";
            this.id = 0;
            this.salary = 0.0;
        }
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public double Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }
        public void print ()
        { Console.WriteLine(name+"\t"+id+"\t"+salary); }

    }
}
