
using System.Net.Http.Headers;
using IS413Mission2;

//Create Roll Results class that will prompt the user and display results
class RollResults
{
    // Create the main method
    static void Main()
    {
        //write prompts to the console welcoming the using and asking them the amount of time they would like to roll
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        //gather number of rolls from the console and user and create an instance object 
        diceRolls diceRolls = new diceRolls();
        int rollNum = int.Parse(Console.ReadLine());

        // create an array for intergers that will store the output of the of the roller method in the diceRolls class
        int[] diceSums = diceRolls.Roller(rollNum);

        //display explanation of output to the console
        Console.WriteLine($"\r\nDICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = {rollNum}.\n");

        // for the possible roll sums of 2-12 determine the percentage of that result and generate the correct number of *s
        //then for each result print out the *s to create a histogram
        for(int i=2; i<=12; i++)
        {
            int percent = diceSums[i] * 100 / rollNum;
            string asteriskCount = new string('*', percent);
            Console.WriteLine($"{i}: {asteriskCount}");
        }

        //print end line to the console
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}



