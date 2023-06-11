using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Figure
    {
        public static double getArea(double radius)
        {
            return Math.Round(radius * radius * Math.PI, 2);
        }

        public static double getArea(double length, double width)
        {
            return length * width;
        }

        public static double getArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)),2);
        }

        public static Boolean checkSqTriangle(double side1, double side2, double side3)
        {

            double chatet1, chatet2;

            if (side1 < side2)
            {
                chatet1 = side1;
                chatet2 = side2;
            }
            else
            {
                chatet1 = side2;
                chatet2 = side1;
            }
            double hypotenuse;
            if (chatet2 > side3)
            {
                hypotenuse = chatet2;
                chatet2 = side3;
            }
            else
            {
                hypotenuse = side3;
            }

            if (hypotenuse * hypotenuse == chatet1*chatet1 + chatet2*chatet2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
