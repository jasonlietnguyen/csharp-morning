using System;

namespace csharp_rps
{
  class Program
  {
    static void Main(string[] args)
    {

      // SlapGame
      // int slap = 1;
      // int punch = 2;
      // int kick = 50;
      // int health = 100;
      // while (health > 0)
      // {
      //   Console.WriteLine("Your health is " + health);
      //   var user = Console.ReadLine().ToLower();
      //   if (user == "slap")
      //   {
      //     health -= slap;
      //   }
      //   else if (user == "punch")
      //   {
      //     health -= punch;
      //   }
      //   else if (user == "kick")
      //   {
      //     health -= kick;
      //   }
      //   else if (user == "quit")
      //   {
      //     health = 0;
      //   }

      //   if (health <= 0)
      //   {
      //     Console.WriteLine("Game Over!!! Do you want to play again Y/N");
      //     var quit = Console.ReadLine().ToLower();
      //     if (quit == "y")
      //     {
      //       health = 100;
      //     }
      //     else if (quit == "n")
      //     {
      //       health = -1;
      //       Console.WriteLine("Thank you for playing! Good Bye.");
      //     }
      //   }
      // }

      bool playing = true;
      while (playing)
      {
        Console.WriteLine("Enter Month");
        var month = Console.ReadLine();
        int numMonth;
        if (!int.TryParse(month, out numMonth))
        {
          Console.WriteLine("Give me a real month number");
        }

        Console.WriteLine("Enter Day");
        var day = Console.ReadLine();
        Console.WriteLine("Enter Day");
        var year = Console.ReadLine();

        var myDate = new Date(numMonth, day, year);
        Console.WriteLine("{0}, {1}, {2}", myDate.Month, myDate.Day, myDate.Year);
      }
    }
  }
}
