using System;
using System.Collections.Generic;

namespace examination_3
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("choose how many players should be playing");
        int numOfPlayers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        int counter = 0;
        while (counter < numOfPlayers )
            counter ++;
        Game game = new Game(counter);
        game.NewGame();
        }
    }
      
}  
  
