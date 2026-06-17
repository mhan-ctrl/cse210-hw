public class Rectangle : Shape
{
    private double _height;
    private double _width;
    public Rectangle(double height, double width, string color)
    {
        _height = height;
        _width = width;
        SetColor(color);
    }
    public override double GetArea()
    {
        return _height * _width;
    }
}