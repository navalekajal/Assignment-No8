using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No8
{
    internal class program4
    {
        static void Main(string[] args)
        {
            Employee2 emp = new Employee2();
            Console.WriteLine("Id");
            emp.Id = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Name");
            emp.Name =(Console.ReadLine());

            Console.WriteLine("Basic Salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DA");
            emp.DA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("HRA");
            emp.HRA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pf");
            emp.Pf = Convert.ToInt32(Console.ReadLine());
            emp.Calculation();
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.salary} {emp.DA} {emp.HRA} {emp.Pf} {emp.gross}");
        }
    }
}
