using System;

namespace Interfaces_Stephen_Livingston
{   
    /// <summary>
    /// New objects are created and arguments are passed through the main method and the describe methods are called and printed to the console. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("M", "FPS", "Fallout New vegas");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("E", "Family", "Finding Nemo");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
