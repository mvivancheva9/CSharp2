using System;
/*
 Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */
class TriangleSurface
{
    static void Main()
    {
        Console.Write("Enter length for side A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter length for side B: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Enter length for side C: ");
        double sideC = double.Parse(Console.ReadLine());

        Console.Write("Enter length for the height: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Enter value for the angle: ");
        double angle = double.Parse(Console.ReadLine());

        AreaBaseAndHeight(sideC, height);// call the method for the area according given base and height
        AreaThreeSides(sideA, sideB, sideC);// call the method for the area given the three sides
        AreaTwoSidesAndAngle(sideA, sideB, angle);// call the method for the area, given two sides and angle
    }
    static void AreaBaseAndHeight ( double side, double height)
    {
        double area = (side * height) / 2;
        Console.WriteLine("The area (Base and Height) is {0:F2}", area);
    }
    static void AreaThreeSides (double sideA, double sideB, double sideC)
    {
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double underRoot = semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC);
        double area = Math.Sqrt(underRoot);// using math class with sqrt property

        Console.WriteLine("The area (Three Sides) is {0:F2}", area);
    }
    static void AreaTwoSidesAndAngle (double sideA, double sideB, double angle)
    {
        double sinAngle = Math.Sin(angle);// using math class with sic property
        double area = ((sideA * sideB) / 2) * sinAngle;

        Console.WriteLine("The area (Two Sides and Angle) is {0:F2}", area);

    }
}
