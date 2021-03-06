﻿/*Problem 5.	Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
 * Examples:
 
 n	    Third digit 7?
5	        false
701	        true
9703	    true
877	        false
777877	    false
9999799	    true


 */

namespace ThirdDigitSeven
{
    using System;

    class ThirdDigitSeven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            /*NOTE: ultimately the integer approach is limiting the checking due to some arithmetic constraints around '1',
                    thus making the solution wrong(the 3rd position should be checked and logged for number dif. than 7) */
            //NB! : Do positional single character checks always string based since they are just a lookup of an index!
            int containerOfThird;
            //moving to 3th position
            containerOfThird = number / 100;

            //checking if the 3th position is seven
            if (containerOfThird % 10 == 7)
            {
                // Note for a case on the C# Fundamentals test
                // true => in the console => True
                Console.WriteLine(true);
            }
            else
            {
                // this will make it
                // false => false, instead of False
                Console.WriteLine(false.ToString().ToLower());
            }
        }
    }
}