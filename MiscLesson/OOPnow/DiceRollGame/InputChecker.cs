using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class InputChecker
{
    
    private int i = 0;
    public string CheckInput(int diceRoll, string userInput)
    {
        int userGuess; 
        if(!Int32.TryParse(userInput, out userGuess))
        {
            return ("Invalid input, enter a number between 1 and 6");
        }

        if(userGuess < 1 || userGuess > 6)
        {
            return ("Invalid input, enter a number between 1 and 6");
        }


        if(diceRoll.ToString() == userInput)
        {
            i = 3;
            return ("Well done, you guessed the number");
            
            
            
        }
        else
        {
            i++;
            return ("Wrong Number");
            
        }
    }

    public int GetWrongGuessCount()
    {
        return i;
    }
}