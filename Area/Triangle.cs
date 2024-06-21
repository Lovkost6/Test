using System.Numerics;

namespace Area;

public class Triangle : IShape
{
    public double SideA { get; private set; }
    public double SideB { get;private set;}
    public double SideC { get;private set;}
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("Неправильные стороны треугольника.");
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    
    public double Area()
    {
        //Полупериметр
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        
        var area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        return area;
    }
    
    // Проверка на прямоугольность
    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
    
    // Проверка что треугольник существует
    private bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
    }
}