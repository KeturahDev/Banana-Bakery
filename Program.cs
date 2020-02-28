using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static Receipt usersReceipt = new Receipt();
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
      Console.WriteLine("Would you like to take a look at our menu, or exit?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Menu  ");
      Console.Write("Leave  :  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();
      
      if (response == "menu")
      {
        Menu();
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
    public static void Menu()
    {
      Console.WriteLine("Here's a menu. You can flip to the back as well to see our special deals.");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("\n           Front             ");
      Console.WriteLine(" =========================== ");
      Console.WriteLine(" Bread - - -      $5         ");
      Console.WriteLine(" Pastry - - -     $2         ");
      Console.WriteLine(" =========================== \n");
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
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("\n            Back             ");
      Console.WriteLine(" =========================== ");
      Console.WriteLine(" Bread - - Buy 2 get 1 FREE! ");
      Console.WriteLine(" Pastry - -    3 for $5!     ");
      Console.WriteLine(" =========================== \n");
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
      Console.WriteLine("Would you like bread or pastry?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Bread  ");
      Console.Write("Pastry  :  ");
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
      string stringAmount = Console.ReadLine();

      
      int amount = int.Parse(stringAmount);
      Bread orderedBread = new Bread(amount);

      int price = orderedBread.CalculatePrice();
      usersReceipt.AddCost(price);
      usersReceipt.checkReceipt();      
      Console.WriteLine($"You've ordered {orderedBread.Amount} rolls of bread!");
      Console.WriteLine($"Your total for that will be ${price}.");
      Console.WriteLine($"Your current total for the day is ${usersReceipt.Total}.");
      Console.WriteLine("Can I get you anything else?");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Pay  ");
      Console.Write("Order  :  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "pay")
      {
        // int price = orderedBread.CalculatePrice();
        // usersReceipt.AddCost(price);
        // Pay(price);
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
      Console.WriteLine("Wonderful choice!");
        
      //here, I will be establishing item being purchased as a string var, item, and pass that into pay, to display that the purchas for pastries was __ price
      //also, will be removing calulation from pay if and place directly under choosing amount of food item for bread as well, like seen bellow

      Console.WriteLine("How many would you like?");
      int amount = int.Parse(Console.ReadLine());
      Pastry orderedPastry = new Pastry(amount);

      int price = orderedPastry.CalculatePrice();
      usersReceipt.AddCost(price);
      // int receiptTotal = usersReceipt.checkReceipt();
      usersReceipt.checkReceipt();
      Console.WriteLine($"You've ordered {orderedPastry.Amount} pastries!");
      Console.WriteLine($"Your total for that will be ${price}.");
      Console.WriteLine($"Your current total for the day is ${usersReceipt.Total}.");
      Console.WriteLine("Can I get you anything else?");
      
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Pay  ");
      Console.Write("Order  :  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "pay")
      {
        // Pay(price);
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
    public static void Pay(int price)
    {
      Console.WriteLine($"Your total for that will be ${price}.");
      Console.WriteLine("Can I get you anything else?");
        
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Yes  ");
      Console.Write("No  :  ");
      Console.ResetColor();
      string response = Console.ReadLine().ToLower();

      if (response == "yes")
      {
        Order();
      }
      else if (response == "no")
      {
        // Console.WriteLine("Thank you for shopping at Banana Bakery! Have a great day!");
        PrintReceipt();
        //continued story..?
      }
      else
      {
        Pay(price);
      }
    }
    public static void PrintReceipt()
    {
      // int receiptTotal = usersReceipt.checkReceipt();
      usersReceipt.checkReceipt();
      Console.WriteLine($"Your total today will be ${usersReceipt.Total}.");
      Console.WriteLine($"Thank you for stopping by! Enjoy!");

      
    }
  }
}