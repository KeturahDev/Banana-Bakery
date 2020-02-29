using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static Receipt usersReceipt = new Receipt();
    public static Pastry orderedPastry = new Pastry(0);
    public static Bread orderedBread = new Bread(0);

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
      Console.WriteLine("We dont have bananas, but you'll go bananas for our baked goods!\n\n");
      Console.ResetColor();
      Bakery();
    }

    public static void Bakery()
    {
      Console.WriteLine("Would you like to take a look at our menu, or exit?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Menu  ");
      Console.Write("Leave  :  ");
      Console.ResetColor();

      string greetingResponse = Console.ReadLine().ToLower();
      if (greetingResponse == "menu")
      {
        Menu();
      }
      else if (greetingResponse == "leave")
      {
        Console.WriteLine("have a nice day!");
      }
      else
      {
        Bakery();
      }
    }

    public static void Menu()
    {
      Console.WriteLine("Here's a menu. You can flip to the back as well to see our special deals.");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("\n+-----------------------------+");
      Console.WriteLine("|             Menu            |");
      Console.WriteLine("| =========================== |");
      Console.WriteLine("|  Bread - - -       $5       |");
      Console.WriteLine("|  Pastry - - -      $2       |");
      Console.WriteLine("| =========================== |");
      Console.WriteLine("+-----------------------------+\n");
      Console.ResetColor();

      Console.WriteLine("Give menu back, or place an order?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Give  ");
      Console.Write("Order  ");
      Console.Write("Flip  :  ");
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
        FlippedMenu();
      }
      else
      {
        Menu();
      }
    }

    public static void FlippedMenu()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("\n+-----------------------------+");
      Console.WriteLine("|            Deals            |");
      Console.WriteLine("| =========================== |");
      Console.WriteLine("| Bread - - Buy 2 get 1 FREE! |");
      Console.WriteLine("| Pastry - -    3 for $5!     |");
      Console.WriteLine("| =========================== |");
      Console.WriteLine("+-----------------------------+\n");
      Console.ResetColor();

      Console.WriteLine("Give menu back, or place an order?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Give  ");
      Console.Write("Order  ");
      Console.Write("Flip  :  ");
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
        Menu();
      }
      else
      {
        FlippedMenu();
      }
    }

    public static void Order()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(@" 
          .----------'    '-.
          /  .      '     .   \\
        /        '    .      /|
        /      .             \ /
      /  ' .       .     .  || 
      /.___________    '    / /
      |._          '------'| /
      '.............______.-'                            
      ");
      Console.ResetColor();
      Console.WriteLine("Would you like bread or pastry?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Bread  ");
      Console.Write("Pastry  :  ");
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
      Console.WriteLine("Get that bread!");

      Console.WriteLine("How many would you like?");
      string stringAmount = Console.ReadLine();

      
      int amount = int.Parse(stringAmount);
      orderedBread.Amount = amount;

      int price = orderedBread.CalculatePrice();
      usersReceipt.AddCost(price);
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"You've ordered ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write($"{orderedBread.Amount}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(" rolls of bread!");
      Console.Write($"Your total for that will be");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write($" ${price}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(".");
      Console.ResetColor();
      Console.WriteLine("Can I get you anything else?");

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Pay  ");
      Console.Write("Order  :  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "pay")
      {
        PrintReceipt();
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
      Console.WriteLine("Sweet! Haha- get it?");
      Console.WriteLine("How many would you like?");
      int amount = int.Parse(Console.ReadLine());
      orderedPastry.Amount = amount;

      int price = orderedPastry.CalculatePrice();
      usersReceipt.AddCost(price);
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"You've ordered ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write($"{orderedPastry.Amount}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(" rolls of bread!");
      Console.Write($"Your total for that will be");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write($" ${price}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(".");
      Console.ResetColor();
      Console.WriteLine("Can I get you anything else?");
      
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Pay  ");
      Console.Write("Order  :  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "pay")
      {
        PrintReceipt();
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
    
    public static void PrintReceipt()
    {
      string amountOfBread = orderedBread.Amount.ToString();
      string amountOfPastries = orderedPastry.Amount.ToString();
      usersReceipt.PrintReceipt();

      Console.WriteLine($"Here's your receipt:");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      Console.WriteLine($"\n+--------------------------+");
      Console.WriteLine($"|         receipt          |");
      Console.WriteLine($"|  ----------------------  |");
      Console.WriteLine($"|   # of Bread --- {amountOfBread}       |");
      Console.WriteLine($"|   # of Pastries --- {amountOfPastries}    |");
      Console.WriteLine($"|                          |");
      Console.WriteLine($"|   Overall Total: ${usersReceipt.Total}     |");
      Console.WriteLine($"+--------------------------+\n");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine($"Thank you for stopping by! Enjoy!");

    }
  }
}