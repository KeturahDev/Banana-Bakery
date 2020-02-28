using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;

      Console.WriteLine(@"                                                                                                          
,--.   ,--.       ,--.                                    ,--.                                            
|  |   |  | ,---. |  | ,---. ,---. ,--,--,--. ,---.     ,-'  '-. ,---.                                    
|  |.'.|  || .-. :|  || .--'| .-. ||        || .-. :    '-.  .-'| .-. |                                   
|   ,'.   |\   --.|  |\ `--.' '-' '|  |  |  |\   --.      |  |  ' '-' '                                   
'--'   '--' `----'`--' `---' `---' `--`--`--' `----'      `--'   `---'                              ,---. 
,-----.                                              ,-----.          ,--.                          |   | 
|  |) /_  ,--,--.,--,--,  ,--,--.,--,--,  ,--,--.    |  |) /_  ,--,--.|  |,-. ,---. ,--.--.,--. ,--.|  .' 
|  .-.  \' ,-.  ||      \' ,-.  ||      \' ,-.  |    |  .-.  \' ,-.  ||     /| .-. :|  .--' \  '  / |  |  
|  '--' /\ '-'  ||  ||  |\ '-'  ||  ||  |\ '-'  |    |  '--' /\ '-'  ||  \  \\   --.|  |     \   '  `--'  
`------'  `--`--'`--''--' `--`--'`--''--' `--`--'    `------'  `--`--'`--'`--'`----'`--'   .-'  /   .--.  
                                                                                           `---'    '--' ");
      Console.ResetColor();
      Bakery();
    }
    public static void Bakery()
    {
      Console.WriteLine("Would you like to take a look at our menue, or exit?");
      Console.ForegroundColor = ConsoleColor.Yellow;
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
      Console.WriteLine("Here's a menue. You can flip to the back as well to see our special deals.");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("\n=============================");
      Console.WriteLine(" Bread - - -      $5         ");
      Console.WriteLine(" Pastry - - -     $2         ");
      Console.WriteLine("=============================\n");
      Console.ResetColor();

      Console.WriteLine("Give menue back, or place an order?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Give  ");
      Console.Write("Order  ");
      Console.Write("Flip  ");
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
      else if (response == "flip")
      {
        FlippedMenue();
      }
      else
      {
        Menue();
      }

    }
    public static void FlippedMenue()
    {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("\n=============================");
      Console.WriteLine(" Bread - - Buy 2 get 1 FREE! ");
      Console.WriteLine(" Pastry - -    3 for $5!     ");
      Console.WriteLine("=============================\n");
      Console.ResetColor();

      Console.WriteLine("Give menue back, or place an order?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Give  ");
      Console.Write("Order  ");
      Console.Write("Flip  ");
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
      else if (response == "flip")
      {
        Menue();
      }
      else
      {
        FlippedMenue();
      }

    }
    public static void Order()
    {
      Console.WriteLine("Would you like bread or pastry?");
      Console.ForegroundColor = ConsoleColor.Yellow;
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

      Console.WriteLine("How many would you like?");
      int amount = int.Parse(Console.ReadLine());
      Bread orderedBread = new Bread(amount);
      // string price = addBread(amount); //in method, turn price into $ amount string
      // Console.Write($"your total is currently ${price}. Would you like anything else?")
      Console.WriteLine($"You've ordered {orderedBread.Amount} rolls of bread!");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Pay  ");
      Console.Write("Order  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "pay")
      {
        int price = orderedBread.CalculatePrice();
        Pay(price);
      }
      else if (response == "order")
      {
        Order();
      }
      else
      {
        Bread();
      }
    }
    public static void Pastry()
    {
      Console.WriteLine("Wonderful choice!");

      Console.WriteLine("How many would you like?");
      int amount = int.Parse(Console.ReadLine());
      Pastry orderedPastry = new Pastry(amount);
      Console.WriteLine($"You've ordered {orderedPastry.Amount} pastries!");
      
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Pay  ");
      Console.Write("Order  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "pay")
      {
        int price = orderedPastry.CalculatePrice();
        Pay(price);
      }
      else if (response == "order")
      {
        Order();
      }
      else
      {
        Pastry();
      }

    }
    public static void Pay(int price)
    {
      Console.WriteLine($"Your total for that will be ${price}.");
      Console.WriteLine("Can I get you anything else?");
        
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Yes  ");
      Console.Write("No  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "yes")
      {
        Order();
      }
      else if (response == "no")
      {
        Console.WriteLine("Thank you for shopping at Banana Bakery! Have a great day!");
        //continued story..?
      }
      else
      {
        Pay(price);
      }
    }
  }
}