using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        protected string name;
        protected int number;

        public Employee()
        {
            this.name = "";
            this.number = 0;
        }
        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public int Number
        {
            set { this.number = value; }
            get { return number; }
        }
        public virtual void print()
        { Console.WriteLine(name + "," + number); }
    } // end class employee
     
    class Salaryemp :Employee
    {
        private double salary;
    
    public  Salaryemp ():base()
{
    this.salary=0.0;
}
    public  Salaryemp (string name,int number,double salary):base(name,number)
{
    this.salary=salary;
}
    public double Salary
{
    set{this.salary=value;}
    get{return salary;}
}
    public override void print ()
{Console.WriteLine(name+"'"+number+"'"+salary);}
}
    class Program
    {
        static void Main(string[] args)
        {
            Employee e=new Employee();
            Employee e1=new Employee("AB",110);
            Salaryemp e2=new Salaryemp ("CD",2107,200000.5);
            e1.print();
            e2.print();
           }
    }   
}
        

    
        
    

