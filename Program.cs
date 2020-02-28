using System;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      //greeting
      Console.WriteLine("Welcome to Banana Bakery!");
      Console.WriteLine("Would you like to take a look at our menue, or exit?");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Menue  ");
      Console.Write("Leave  ");
      string response = Console.ReadLine().ToLower();
      

    }
  }
}