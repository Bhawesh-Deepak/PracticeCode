using FactoryDesignPattern;
using System;
using System.Net.Http.Headers;

namespace PracticeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeFactory empFacttory= new EmployeeFactory();
            var emp=empFacttory.GetEmployeeFactory("Contract");
            Console.WriteLine(emp.GetIncome(100));
            Console.ReadKey();
        }
    }
}
