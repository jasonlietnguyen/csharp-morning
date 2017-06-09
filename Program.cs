using System;

namespace csharp_rps
{
  class Program
  {
    static void Main(string[] args)
    {
      int slap = 1;
      int punch = 2;
      int kick = 50;
      int health = 100;
      while (health > 0)
      {
        Console.WriteLine("Your health is " + health);
        var user = Console.ReadLine().ToLower();
        if (user == "slap")
        {
          health -= slap;
        }
        else if (user == "punch")
        {
          health -= punch;
        }
        else if (user == "kick")
        {
          health -= kick;
        }
        else if (user == "quit")
        {
          health = 0;
        }

        if (health <= 0)
        {
          Console.WriteLine("Game Over!!! Do you want to play again Y/N");
          var quite = Console.ReadLine().ToLower();
          if (quite == "y")
          {
            health = 100;
          }
          else if (quite == "n")
          {
            health = -1;
            Console.WriteLine("Thank you for playing! Good Bye.");
          }
        }
      }
    }
  }
}
