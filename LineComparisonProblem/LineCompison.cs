using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineCompison
    {
        public static int x1, x2, x3, x4, y1, y2, y3, y4;
        public static double length1, length2;
        public void LinelengthCompison()
        {
            Console.WriteLine("Enter the value of x1,y1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 ,y2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x3,y3");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4 ,y4:");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
        }
        public void lengthCalculate()
        {
            length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("length of line1 is:" + length1);
            Console.WriteLine("Length of line2 is:" + length2);
            Console.ReadLine();
        }
        public void ifEquals()
        {
            if (length1.Equals(length2))
            {
                Console.WriteLine("Two lines are equal");
                if (length1.CompareTo(length2) == 1)

                    Console.WriteLine(" length of line one is greater than line2");

            }

            else if (length1.CompareTo(length2) == -1)

                Console.WriteLine(" length of line one is less than line2");

            else
            {
                Console.WriteLine("two lines are not equal");
            }

            Console.WriteLine(" length of Both line is equal");




            Console.ReadLine();



            if (length1.Equals(length2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
   
     
    }
}
     






