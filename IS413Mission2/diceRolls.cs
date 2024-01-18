using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS413Mission2
{
    //Create diceRolls Class
    internal class diceRolls
    {
        // make a private variable for generating random numbers
        private Random rnd = new Random();

        // create the Roller method that accepts the roll number as a parameter and returns and array of integers
        public int[] Roller(int rollNum)
        {
            // create array with 11 slots for integers
            int[] diceSums = new int[13];

            //for the amount of rolls desired by the user generate the 2 dice values and their sum, add the sum to the array
            //and increment the are by 1 each time through the loop
            for (int i = 0; i < rollNum; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int sum = dice1 + dice2;
                diceSums[sum]++;
            }

            //return the array as the result of the method
            return diceSums;
        }
    }
}
