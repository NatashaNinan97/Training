using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, b, h, bas, s, area;
            double r;

            Program a = new Program();

            Console.WriteLine(Enter length and breadth);
            l = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int rect = a.Area(l, b)
            Console.WriteLine("Area of rectangle:" + rect);

            Console.WriteLine(Enter height, bas, 0.5);
            h = int.Parse(Console.ReadLine());
            bas = int.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            int tri = a.Area(h, bas, v)
            Console.WriteLine("Area of triangle:" + tri);

            Console.WriteLine(Enter 3.14, r);
            p = int.Parse(Console.ReadLine());
            r = double.Parse(Console.ReadLine());
            int cir = a.Area(p, r)
            Console.WriteLine("Area of circle:" + cir);

            Console.WriteLine(Enter side);
            s = int.Parse(Console.ReadLine());
            int sq = a.Area(s)
            Console.WriteLine("Area of triangle:" + sq);
        }

            public void Area(int l, int b)
            {
                area = l * b;
            }
            public void Area(int h, int bas, int v)
            {
                area = v * h * bas;
            }
            public void Area(int p, double r)
            {
                area = l * b;
            }
            public void Area(int s)
            {
                area = s * s;
            }
    }
}
