using System;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      //greeting
      Console.WriteLine("Welcome to Banana Bakery!");
      Bakery();
    }
    public static void Bakery()
    {
      Console.WriteLine("Would you like to take a look at our menue, or exit?");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Menue  ");
      Console.Write("Leave  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();
      
      if (response == "menue")
      {
        Menue();
      }
      else if (response == "leave")
      {
        Console.WriteLine("have a nice day!");
      }
      else
      {
        Main();
      }
    }
    public static void Menue()
    {
      Console.WriteLine("Here's a menue:");
      Console.WriteLine("============================");
      Console.WriteLine("Bread - - - $5");
      Console.WriteLine("Pastry - - - $2");
      Console.WriteLine("============================");

      Console.WriteLine("Give menue back, or place an order?");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Give  ");
      Console.Write("Order  ");
      Console.ResetColor();

      string response = Console.ReadLine().ToLower();

    }
  }
}