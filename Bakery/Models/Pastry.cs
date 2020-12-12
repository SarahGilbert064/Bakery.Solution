using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NewPastry { get; set; }
    public int PriceOfPastry = 2;

    public Pastry(int newPastry)
    {
      NewPastry += newPastry;
    }
    public int ReturnPastryPrice(int newPastry)
    {
      int finalPastryPrice = 0;
      for (int i = 1; i <= newPastry; i++)
      {
        if(i == 1)
        {
          finalPastryPrice+= 2;
        }
        else
        {
          finalPastryPrice += 0;
        }
      }
      return finalPastryPrice;
    }

    // public int FinalPrice(int newPastry)
    // {
    //   int finalAmount = PriceOfPastry * newPastry;
    //   {
    //     if (newPastry % 3 == 0)
    //     {
    //       finalAmount -= 1;
    //     }
    //   }
    //   return finalAmount;
    // }
  }
}