using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects1
{
    class Shapes
    {

        public void Area(double length, double breadth)
        {
            Console.WriteLine("The area of the rectangle is: " + (length * breadth));
        }

        public void Area(float base1, double height)
        {
            Console.WriteLine("The area of the triangle is: " + (base1 * height / 2));
        }

        public void Area(double radius)
        {
            Console.WriteLine("The area of the circle is: " + (3.14 * Math.Pow(radius, 2)));
        }

        public void Area(float side)
        {
            Console.WriteLine("The area of the square is: " + Math.Pow(side, 2));
        }
    }

    class Shapes_test
    {
        static void Main()
        {
            Shapes p1 = new Shapes();
            for(; ; )
            {
                Console.WriteLine("Enter 1 for rectangle, 2 for triangle, 3 for circle and 4 for square:");
                Console.WriteLine("Enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter the length and breadth of a rectangle:");
                        double l = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        p1.Area(l, b);
                        break;
                    case 2:
                        Console.WriteLine("Enter the base and height of a triangle:");
                        float b1 = float.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        p1.Area(b1, h);
                        break;
                    case 3:
                        Console.WriteLine("Enter the radius of a circle:");
                        double r = double.Parse(Console.ReadLine());
                        p1.Area(r);
                        break;
                    case 4:
                        Console.WriteLine("Enter the side of a square:");
                        float s = float.Parse(Console.ReadLine());
                        p1.Area(s);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
                Console.WriteLine("if you don't want to continue press 1");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                    break;
            }
            Console.ReadKey();
        }
    }
}
