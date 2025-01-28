//Declaring method for our calculations
void Calculation(int a,int  b, string @operator, int result)
{
    Console.WriteLine(a + " " + @operator + " " + b + " = " + result);
    Console.WriteLine("Press any key to exit.");
}

//assigning and parsing to int our first number
Console.WriteLine("Hello");
Console.WriteLine("Input first number");
var numberOneStr = Console.ReadLine();
int numberOne = int.Parse(numberOneStr);

//assigning and parsing to int our second number
Console.WriteLine("Input second number");
var numberTwoStr = Console.ReadLine();
int numberTwo = int.Parse(numberTwoStr);

Console.WriteLine("What wuld you like to do?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userInput = Console.ReadLine();
userInput = userInput.ToUpper();// making sure all our inputs are capitalised
//carrying out our calculations
if (userInput == "A")
{
    var sum = numberOne + numberTwo;
    Calculation(numberOne, numberTwo, "+", sum);
}
else if (userInput == "S")
{
    var difference = numberOne - numberTwo;
    Calculation(numberOne, numberTwo, "-", difference);
}
else if (userInput == "M")
{
    var times = numberOne * numberTwo;
    Calculation(numberOne, numberTwo, "*", times);
}
else
{
    Console.WriteLine("Invalid Input");
    Console.WriteLine("Press any key to exit.");
}




Console.ReadKey();
