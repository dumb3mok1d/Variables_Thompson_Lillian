using System;

namespace Variables_Thompson_Lillian
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            // Booleans initialized to flase for jumping and running
            bool isJumping = false, isRunning = false;
            // Declares random float variable
            float myFloat;
            // Assigning myFloat to 54.65
            favoriteNumber = 6;
            myFloat = 54.65f;
            // Initializing constant finalGrade 90
            const double finalGrade = 90.0;

            // Prints all variables to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
