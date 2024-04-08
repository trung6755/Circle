using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2, "Blue");
            Console.WriteLine(circle);

            Console.WriteLine();

            Cylinder cylinder = new Cylinder(3,5, "Green");
            Console.WriteLine(cylinder);

            Console.ReadKey();
        }
    }
}
