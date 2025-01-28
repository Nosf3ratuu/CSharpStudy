Console.WriteLine("Enter a number");
var userInput = Console.ReadLine();

bool isParsingSuccessful = int.TryParse(userInput, out int number);

if(isParsingSuccessful)
{
    Console.WriteLine("Parsing successful, number is " + number);
}
else
{
    Console.WriteLine("Parsing failed.");
}

Console.ReadKey();