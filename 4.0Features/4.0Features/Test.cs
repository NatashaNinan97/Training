using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0Features
{
    class Test
    {
        const double pi = 3.14;
        readonly double temp = 98.6;

        public Test()
        {
            temp = 100.2;
        }
        public void Show()
        {
            Console.WriteLine("Area of circle with 5cm radius: "+pi*Math.Pow(5,2));
            Console.WriteLine("This object has fever of: " + temp);
        }
        public void Display(int id, string name, char gen, DateTime DOB, string email="info@itc.com",long mobno=9999999999)
        {
            Console.WriteLine("Data: {0}, {1}, {2}, {3}, {4}, {5} ", id,name,gen,DOB,email,mobno  );

        }

        public void StudentMarks(int regno, string name, int sem,params double[] marks)
        {
            Console.WriteLine("RegNo: "+regno );
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Sem: " + sem);
            Console.WriteLine("Marks: ");
            foreach (var m in marks)
                Console.WriteLine(m);
        }
    }
}
