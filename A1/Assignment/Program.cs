using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int empID;
            double basic, special, taxsaving, taxamt;

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter empID:");
            empID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter basic monthly salary:");
            basic = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter special monthly allowance:");
            special = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tax saving:");
            taxsaving = double.Parse(Console.ReadLine());

            double annualsalary = (basic + special) * 12;
            double bonus = (12 * basic) * 0.1;
            double annualgross = annualsalary + bonus;
            double save = taxsaving * 12;
            double annualnet = annualgross - save;

            if (annualnet <= 100000)
            {
                taxamt = 0;
            }
            else if (annualnet > 100000 && annualnet <= 150000)
            {
                taxamt = (annualnet * 0.2);
            }
            else
            {
                taxamt = (annualnet) * 0.3;
            }

            Console.WriteLine("Gross annual salary:" + annualgross);
            Console.WriteLine("Net annual salary:" + annualnet);
            Console.WriteLine("Tax:" + taxamt);
        }
    }
}
