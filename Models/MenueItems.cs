namespace Bakery.Models
{
  public class Bread
  {
    public int Amount {get; set;}
    public Bread(int amount)
    {
      Amount = amount;
    }
    public int CalculatePrice()
    {
      int price = 0;
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 == 0)
        {
          price = price; //its free
        }
        else
        {
          price = price += 5;
        }
      }
      return price;
    }
  }

  public class Pastry
  {
    public int Amount {get; set;}
    public Pastry(int amount)
    {
      Amount = amount;
    }
    public int CalculatePrice()
    {
      if (Amount == 3)
      {
        return 5;
      }
      else
      {
        return Amount * 2;
      }
    }
  }
}
