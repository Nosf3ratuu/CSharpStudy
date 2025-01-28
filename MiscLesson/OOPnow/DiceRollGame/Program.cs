var dice1 = new Dice();
var guesser = new TakeInput();

Console.WriteLine("A dice has been rolled. You have 3 tries to guess it.");
int diceNumber = dice1.RollTheDice();
var inputChecker = new InputChecker();
while(inputChecker.GetWrongGuessCount()!= 3)
{
    Console.WriteLine(inputChecker.CheckInput(diceNumber, guesser.getInput()));
}
Console.WriteLine("Game over, play again?");


