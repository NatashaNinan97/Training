using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Display(12, "Martin", 'M', DateTime.Parse("12/23/2001"), "martin@gmail.com", 9300008765);
            t.Display(name: "Ford", email: "Ford@gmail.com", gen: 'M', DOB: DateTime.Now, id: 100, mobno: 9876543232);
            t.Display(12, "Blake", 'F', DateTime.Parse("09/21/2003"));

            int age = 20;
            Console.WriteLine(age.GetType()+","+age);

            var agevar = 35;
            Console.WriteLine(agevar.GetType()+","+agevar);

            dynamic agenew;
            agenew = 18;
            Console.WriteLine(agenew.GetType()+","+agenew);
            agenew = "Twenty Two";
            Console.WriteLine("New Age: " + agenew);

            t.StudentMarks(12, "Smith", 3, 34, 56, 78, 90);
            t.StudentMarks(13,"King", 5, 90, 89, 78, 67, 56, 45, 34, 23);

            t.Show();

            try
            {
                checked
                {
                    int num = int.MaxValue;
                    num++;
                    Console.WriteLine("Num: " + num);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }

        }
    }
}
