class Rectangle
{
    //create constructor
    public Rectangle(int width, int height)
    {
       Width = GetLengthOrDefault(width, nameof(Width));
       _height = GetLengthOrDefault(height, nameof(_height));
    }

 
    public int Width {get; private set;}
    private int _height;
    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if(value >0)
        {
            _height = value;
        }
    }
    private int GetLengthOrDefault(int length, string name)
    {
       const int defaultValueIfNonPositive = 1;
        if(length <= 0)
        {
            Console.WriteLine($"{name} must be positive.");
           return defaultValueIfNonPositive;
        }
        return length;
    }

    public int CalculatePerimiter() => 2 * Width + 2 * _height;

    public int CalculateArea() => Width * _height;//paramaterless method - represents actions

    public string Description => $"A rectangle with width of {Width} "  +
        $"and a height of {_height}."; //computeted property - should never be performance heavy - represnts data
   
}
