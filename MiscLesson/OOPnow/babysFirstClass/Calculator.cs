static class Calculator //stateless - has no fields    
{
    public static int Add(int a, int b) => a + b; //so we use static methods - calling on the class, not instances
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

}
