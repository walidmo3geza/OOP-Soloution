using System;

namespace lap6OOP
{
    abstract class Person
    {
        protected int id;
        protected string name;
        public Person()
        {
            id = 0;
            name = "";
        }
        public Person(int num, string s)
        {
            id = num;
            name = s;
        }
        public void setID(int num) { id = num; }
        public void setName(string s) { name = s; }
        public int getID() { return id; }
        public string getName() { return name; }
        public abstract void print_data();
    };
    class Customer : Person
    {
        int account_number;
        public Customer() : base()
        {
            account_number = 0;
        }
        public Customer(int num1, string s, int num2) : base(num1, s)
        {
            account_number = num2;
        }
        public void setAccountNumber(int num) { account_number = num; }
        public int getAccountNumber() { return account_number; }
        public override void print_data()
        {
            Console.WriteLine($"The ID of cusomer = {this.getID()}");
            Console.WriteLine($"The name of cusomer is {this.getName()}");
            Console.WriteLine($"The account number of cusomer = {this.getAccountNumber()}");
        }
    }    class Employee : Person
    {
        float salary;
        public Employee() : base()
        {
            salary = 0.0f;
        }
        public Employee(int num, string s, float sa) : base(num, s)
        {
            salary = sa;
        }
        public void setSalary(float sa) { salary = sa; }
        public float getSalary() { return salary; }
        public override void print_data()
        {
            Console.WriteLine($"The ID of Employee = {this.getID()}");
            Console.WriteLine($"The name of employee is {this.getName()}");
            Console.WriteLine($"The salary of employee = {this.getSalary()}");
        }
    };
    internal class Program
    {
        public static void fill_data(Employee emp)
        {
            Console.Write("Enter the ID of employee :");
            int id = int.Parse(Console.ReadLine());
            emp.setID(id);
            Console.Write("Enter the name of employee :");
            string name = Console.ReadLine();
            emp.setName(name);
            Console.Write("Enter the salary of employee :");
            float salary = float.Parse(Console.ReadLine());
            emp.setSalary(salary);
            //emp = new Employee(id, name, salary);
        }
        public static void print_employee(Person p)
        {
            //Console.WriteLine($"The ID of Employee = {emp.getID()}");
            //Console.WriteLine($"The name of employee is {emp.getName()}");
            //Console.WriteLine($"The salary of employee = {emp.getSalary()}");
            p.print_data();
        }
        static void Main(string[] args)
        {
            
            Person emp = new Employee(1, "ali", 5000.555f);
            emp.print_data();


            Console.WriteLine();


            Person cust = new Customer(1, "ahmed", 123);
            cust.print_data();

        }
    }
}
