using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Receipt
  {
    public int Total { get; set; }
    public List<int> ItemPrices { get; set; } = new List<int>();

    public void AddCost(int cost)
    {
      ItemPrices.Add(cost);
    }
    public void PrintReceipt()
    {
      foreach (int price in ItemPrices)
      {
        Total = Total += price;
      }
    }
  }
}