using System;

namespace lap6OOP
{
    class Person
    {
        protected int id;
        protected string name;
        public Person()
        {
            id = 0;
            name = "";
        }
        public Person(int num,string s)
        {
            id = num;
            name = s;
        }
        public void setID(int num) { id = num; }
        public void setName(string s) { name = s; }
        public int getID() { return id; }
        public string getName() { return name; }
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
    };
    class Employee : Person
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
    };
    internal class Program
    {
        public static void fill_data(Employee emp)
        {
            Console.Write("Enter the ID of employee :");
            int id = int.Parse(Console.ReadLine());
            emp.setID(id);
            Console.Write("Enter the name of employee :");
            string name=Console.ReadLine();
            emp.setName(name);
            Console.Write("Enter the salary of employee :");
            float salary = float.Parse(Console.ReadLine());
            emp.setSalary(salary);
            //emp = new Employee(id, name, salary);
        }
        public static void print_employee(Employee emp)
        {
            Console.WriteLine($"The ID of Employee = {emp.getID()}");
            Console.WriteLine($"The name of employee is {emp.getName()}");
            Console.WriteLine($"The salary of employee = {emp.getSalary()}");
        }
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            fill_data(emp);
            print_employee(emp);
        }
    }
}

