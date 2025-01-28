string ConvertPointsToGrade(int points)
{
    string result;
    switch(points)
    {
        case 10:
        case 9:
            return "A";
        case 8:
        case 7:
        case 6:
            return "B";
        case 4:
        case 3:
            return "C";
        case 2:
        case 1:
            return "D";
        case 0:
            return "E";
        default:
            return "!";

    }
}
Console.WriteLine("How many points?");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Your score is " + ConvertPointsToGrade(x));
Console.ReadKey();