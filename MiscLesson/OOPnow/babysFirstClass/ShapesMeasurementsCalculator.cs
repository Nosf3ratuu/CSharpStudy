class ShapesMeasurementsCalculator
{
    public int CalculateRectanglePerimiter(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.GetHeight();
    

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.GetHeight();
    
}