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
    public int ReturnBreadPrice(int numOfLoafs)
    { 
      int finalBreadPrice = 0;
      for (int i = 1; i <= numOfLoafs; i++)
      {
        // if(i % 3 ==0)
        // {
        //   finalBreadPrice = PriceOfLoaf;
        // }
        if(i == 1)
        {
          finalBreadPrice += 5;
        }
        else
        {
          finalBreadPrice += 0;
        }
      }
      return finalBreadPrice;
    }
  }
}