namespace Area;

public class Circle : IShape
{
    public double Radius { get; private set; }
    
    public Circle(double radius)
    {
        if (radius<=0)
            throw new ArgumentException("Неправильный радиус.");
        Radius = radius;
    }


    public double Area()
    {
        var area = Math.PI * Radius * Radius;
        return area;
    }
}