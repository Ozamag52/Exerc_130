using System;
using Exerc130.Entities.Class;
using System.Collections.Generic;
namespace Exerc130
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsourced (y/n)? ");
                char employeeType = char.Parse(Console.ReadLine());
                if (employeeType == 'n' || employeeType == 'N')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employeeList.Add(employee);
                }
                else if (employeeType == 'y' || employeeType == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutSourcedEmployee(name, hours, valuePerHour,additionalCharge);
                    employeeList.Add(employee);
                }
                
            }
            Console.WriteLine("PAYMENT");
            foreach (Employee e in employeeList)
            {
                Console.WriteLine(e.Name + " - " + " $ " + e.Payment());
            }
        }
    }
}
