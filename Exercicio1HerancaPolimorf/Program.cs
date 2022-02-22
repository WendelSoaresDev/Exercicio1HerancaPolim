using System;
using Exercicio1HerancaPolimorf.Entities;
using System.Globalization;

namespace Exercicio1HerancaPolimorf
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n):");
                char outEmp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());

                if (outEmp == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hours, valueHour, addCharge));

                }

                else 
                {
                    list.Add(new Employee(name, hours, valueHour));
                }


            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment());
            }


        }
    }
}