Console.WriteLine("Enter a word:");
var userInput = Console.ReadLine();
while (userInput.Length < 15)
{
    userInput += 'a';
    Console.WriteLine(userInput);
}
Console.WriteLine("Loop is finished");
Console.ReadKey();

string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word = Console.ReadLine();
}
while(word.Length <= 10);
Console.ReadKey();

  string RepeatCharacter(char character, int targetLength)
{
    string strOfCharacter = "";
    do
    {
        strOfCharacter += character;
    }
    while (strOfCharacter.Length < targetLength);
    return strOfCharacter;
}

int UserNumber;
do
{
    Console.WriteLine("Enter a number larger than 10:");
    var userNumberStr = Console.ReadLine();

    if (userNumberStr == "stop")
    { 
        break;
    }
    UserNumber = int.Parse(userNumberStr); 
}
while (UserNumber < 10);

Console.WriteLine("The loop is finished");
Console.ReadKey();