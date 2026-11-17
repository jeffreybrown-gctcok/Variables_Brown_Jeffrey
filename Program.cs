using System;

namespace MyProject
{
    internal class Variables
    {

        

      
        static void Main(string[] args)
        {
            int favoriteNumber = 6;
            bool isJumping = false;
            bool isRunning = false;
            float randomVariable = 9.5f;
            double finalGrade = 98;

            Console.WriteLine("My favorite number is: " + favoriteNumber);
            Console.WriteLine("Is the character jumping?" + isJumping);
            Console.WriteLine("Is the character running?" + isRunning);
            Console.WriteLine("Current speed: " + randomVariable);
            Console.WriteLine("Final grade: " + finalGrade);

        }
    }
}