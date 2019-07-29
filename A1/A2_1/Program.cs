using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_1
{
    class Accounts
    {
        static void Main(string[] args)
        {
            double accno, amt, bal;
            string acctype, name;
            char trans;

            Console.WriteLine("Enter Acc No:");
            accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Acc Type:");
            acctype = Console.ReadLine();
            Console.WriteLine("Enter Customer name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type(d|w):");
            trans = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount:");
            amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Balance:");
            bal = int.Parse(Console.ReadLine());

            Accounts a = new Accounts(double accno, string acctype, string name, char trans, double amt, double amt);

            if (trans=='d')
            {
                void credit(int amt)
                {
                    bal = bal + amt;
                }
            }
            else if (trans == 'w')
            {
                void debit(int amt)
                {
                    bal = bal - amt;
                }
            }

            Console.WriteLine("Account number:" );
        }
    }
}
