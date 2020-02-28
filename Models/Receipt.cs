using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Receipt
  {
    public List<int> itemsPrices = new List<int>() {0};

    public int Total { get; set; }
    public List<int> ItemPrices { get; set; }

    public Receipt()
    {
      ItemPrices = itemsPrices;
      Total = 0;
    }

    public void AddCost(int cost)
    {
      ItemPrices.Add(cost);
    }
    public int PrintReceipt()
    {
      foreach (int price in ItemPrices)
      {
        Total = Total += price;
      }
      return Total;
    }
  }
}