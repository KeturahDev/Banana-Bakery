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
          price +=0 ; //its free
        }
        else
        {
          price += 5;
        }
      }
      return price;
    }
    public void AddToTotalAmount(int amount)
    {
      Amount = Amount += amount;
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
      int price = 0;
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 == 0 && i < 4)
        {
          price = 5 ;
        }
        else
        {
          price += 2;
        }
      }
      return price;
    }
    public void AddToTotalAmount(int amount)
    {
      Amount = Amount += amount;
    }
  }
}
