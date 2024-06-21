namespace Area;

public class ShapeAreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.Area();
    }
}