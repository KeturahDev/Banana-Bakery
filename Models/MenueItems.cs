namespace Bakery.Models
{
  public class Bread
  {
    public int Amount {get; set;}

    public Bread(int amount)
    {
      Amount = amount;
    }

    // public static int CalculatePrice()
    // {
    //   //if amount == 3, discount, else
    //   //cost == amount * 5
    // }
  }
  public class Pastry
  {
    public int Amount {get; set;}

    public Pastry(int amount)
    {
      Amount = amount;
    }

    // public static int CalculatePrice()
    // {
    //   //if amount == 3, discount, else
    //   //cost == amount * 5
    // }
  }
}
