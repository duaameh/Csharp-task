using System;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 30;
            person.SayHello();

            Person p=new Person();
            p.Name = "duaa";
            p.Age = 23;
            p.SayHello();
            Person ctor=new Person("sara",20);
        }
    }
    public class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public Person()
        {
            
        }
        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
    public class Employee
    {
        private string _name;

        public int EmployeeId { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        //public string Name { set; get; }
        public string Department { get; set; } // auto Properties, 
        public decimal Salary { get; set; }
    }
}
