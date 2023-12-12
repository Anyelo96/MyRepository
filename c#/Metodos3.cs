/*converts currency*/
/*
double usd = 23.73;
int rate = 23500;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");

int UsdToVnd(double usd) 
{
    return (int)(usd*rate);
}

*/
/*Dice game*/

/*
using System.Net;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;

Random random = new Random();


Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
    PlayGame();


void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(0,6);
        var roll= random.Next(0,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int target, int roll)
{
    if(target<roll)
        return "you win";
    else
        return "you loss";

}


bool ShouldPlay()
{   
    
    while(true)
    {
        string continueGame = Console.ReadLine();
        continueGame = continueGame.ToLower();
        if(continueGame == "y")
        {
            return true;
        }

        else if(continueGame == "n")
        {
            Console.WriteLine("thank for playing");
            return false;
        }

        else
            Console.WriteLine("Just N or Y.");
    }
    
}
*/