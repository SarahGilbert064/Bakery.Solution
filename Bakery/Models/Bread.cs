using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NewLoaf { get; set; }
    public int PriceOfLoaf = 5;

    public Bread(int newLoaf)
    {
      NewLoaf += newLoaf;
    }
    public int ReturnBreadPrice(int newLoaf)
    { 
      int breadPrice = 0;
      for (int i = 1; i <= newLoaf; i++)
      {
        if(i == 1)
        {
          breadPrice += 5;
        }
        else
        {
          breadPrice += 0;
        }
      }
      return breadPrice;
    }

    public int FinalPrice(int newLoaf)
    {
      int finalAmount = PriceOfLoaf * newLoa;
      {
        if (newLoaf % 3 == 0)
        {
          finalAmount -= 5;
        }
      }
      return finalAmount;
    }
  }
}

