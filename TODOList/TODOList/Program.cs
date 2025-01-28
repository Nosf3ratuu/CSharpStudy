Console.WriteLine("Hello!");
//assign variable of the user choice for later
var userChoice = "";
//method to show the menu
void PrintSelectionScreen()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODO's]");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit app");

    userChoice = Console.ReadLine();
    userChoice = userChoice.ToUpper();
    CheckInput();
}
//assign bool used for checking user input
bool choiceIsValid = true;
//method to check user input
void CheckInput()
{
    do
    {
        switch (userChoice)
        {
            case ("S"):
                ShowToDos();
                choiceIsValid = true;
                break;
            case ("A"):
                AddTODO();
                choiceIsValid = true;
                break;
            case ("R"):
                RemoveTODO();
                choiceIsValid = true;
                break;
            case ("E"):
                Console.WriteLine("Exit");
                choiceIsValid = true;
                break;
            default:
                Console.WriteLine("Invalid Choice");
                choiceIsValid = false;
                PrintSelectionScreen();
                break;
        }
    }
    while (choiceIsValid == false);
}
// initialize list of TODOs
var TODOs = new List<string> { };
//method for seeing all TODOs
void ShowToDos()
{
    Console.WriteLine("Show TODOs");
    if (TODOs.Count == 0)
    {
        Console.WriteLine("No TODOs added yet");
        PrintSelectionScreen();
    }
    else
    {
        int count = 1;
        foreach (var todo in TODOs)
        {
            Console.WriteLine(count.ToString() + ". " + todo);
            count++;
        }
    }
    PrintSelectionScreen();
}
//method to add a TODO
void AddTODO()
{
    Console.WriteLine("Add TODO:");
    string newTODO = Console.ReadLine();
    if (TODOs.Contains(newTODO))
    {
        Console.WriteLine("The description must be unique");
        AddTODO();
    }
    else if (newTODO == "")
    {
        Console.WriteLine("Description cannot be empty");
        AddTODO();

    }
    else
    {
        TODOs.Add(newTODO);
        Console.WriteLine("New TODO added;" + newTODO);
        PrintSelectionScreen();
    }
}
//method for removing a TODO
void RemoveTODO()
{
    Console.WriteLine("Select the index of a TODO to remove.");
       if (TODOs.Count == 0)
    {
        Console.WriteLine("No TODOs added yet");
        PrintSelectionScreen();
    }
    else
    {
        int count = 1;
        foreach (var todo in TODOs)
        {
            Console.WriteLine(count.ToString() + ". " + todo);
            count++;


        }
    }
    var toDoRemoved = Console.ReadLine();
    bool isParsingSuccessful = int.TryParse(toDoRemoved, out int intToDoRemoved);
    if (!isParsingSuccessful)
    {
        Console.WriteLine("Index is invalid, select correct index");
        RemoveTODO();
    }
    else if(intToDoRemoved<=0 | intToDoRemoved> TODOs.Count )
    {
        Console.WriteLine("Index is invalid, select correct index");
        RemoveTODO();
    }
    else
    { 
        Console.WriteLine("TODO removed: " + TODOs[intToDoRemoved -1] );
        TODOs.RemoveAt(intToDoRemoved -1);
    }
    PrintSelectionScreen();
} 
PrintSelectionScreen();
Console.ReadKey();

