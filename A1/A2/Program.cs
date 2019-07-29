using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemcode, qty, price;
            string desc,pay;
            char choice;
            double disc,total, grand=0;

            do
            {
                Console.WriteLine("Enter itemcode:");
                itemcode = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter description:");
                desc = Console.ReadLine();
                Console.WriteLine("Enter quantity:");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter price:");
                price = int.Parse(Console.ReadLine());

                total = qty * price;
                grand = grand + total;
                Console.WriteLine("Enter choice as y or n:");
                choice = char.Parse(Console.ReadLine());
            }
            while (choice=='y');

            Console.WriteLine("Enter payment method:");
            pay = Console.ReadLine();

            if (grand>10000)
            {
                disc = (0.1 * grand);
                grand = grand - disc;
            }
            else if(grand<1000)
            {
                if(pay=="card")
                {
                    grand = grand + (grand * 0.025);
                }
            }

            Console.WriteLine("Grand Total: " +grand);

        }
    }
}
