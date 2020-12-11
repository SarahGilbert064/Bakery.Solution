using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NewPastry { get; set; }
    public int PriceOfPastry = 2;

    public int ReturnPastryPrice(int numOfPastries)
    {
      int finalPastryPrice = 0;
      for (int i = 1; i <= numOfPastries; i++)
      {
        if(i == 1)
        {
          finalPastryPrice+=2;
        }
        else
        {
          finalPastryPrice += 0;
        }
      }
      return finalPastryPrice;
    }
  }
}