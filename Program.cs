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

      if (response == "give")
      {
        Bakery();
      }
      else if (response == "order")
      {
        Order();
      }
      else
      {
        Menue();
      }

    }
    public static void Order()
    {
      Console.WriteLine("Would you like bread or pastry?");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Bread  ");
      Console.Write("Pastry  ");
      // Console.Write("change mind  ");
      // Console.Write("run out of store crying  ");
      Console.ResetColor();

      string response = Console.ReadLine().ToLower();

      if (response == "bread")
      {
        Bread();
      }
      else if (response == "pastry")
      {
        Pastry();
      }
      else
      {
        Order();
      }

    }
    public static void Bread()
    {
      Console.WriteLine("Wonderful choice!");

    //   Console.WriteLine("How many would you like?");
    //   int amount = int.Parse(Console.ReadLine());

    //   string price = addBread(amount); //in method, turn price into $ amount string
    //   Console.Write($"your total is currently ${price}. Would you like anything else?")

    //   Console.ForegroundColor = ConsoleColor.Blue;
    //   Console.Write("Pay  ");
    //   Console.Write("Oder  ");
    //   Console.ResetColor();
    //   string response = Console.ReadLine().ToLower();

    //   if (response == "pay")
    //   {
    //     // Pay();
    //   }
    //   else if (response == "order")
    //   {
    //     Order();
    //   }
    //   else
    //   {
    //     Bread();
    //   }
    }
    public static void Pastry()
    {
      Console.WriteLine("Wonderful choice!");

    //   Console.WriteLine("How many would you like?");
    //   int amount = int.Parse(Console.ReadLine());

    //   string price = addPastry(amount); //in method, turn price into $ amount string
    //   Console.Write($"your total is currently ${price}. Would you like anything else?")

    //   Console.ForegroundColor = ConsoleColor.Blue;
    //   Console.Write("Pay  ");
    //   Console.Write("Oder  ");
    //   Console.ResetColor();
    //   string response = Console.ReadLine().ToLower();

    //   if (response == "pay")
    //   {
    //     // Pay();
    //   }
    //   else if (response == "order")
    //   {
    //     Order();
    //   }
    //   else
    //   {
    //     Pastry();
    //   }

    }
  }
}