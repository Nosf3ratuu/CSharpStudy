var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();
Console.WriteLine("Width is: " + rectangle1.Width);

Console.WriteLine("Height is: " + rectangle1.GetHeight());
Console.WriteLine("Perimiter is:" + rectangle1.CalculatePerimiter());
Console.WriteLine("Area is:" + calculator.CalculateRectangleArea(rectangle1));

Console.ReadKey();
