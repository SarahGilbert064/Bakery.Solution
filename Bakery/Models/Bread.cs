using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NewLoaf { get; set; }
    public int PriceOfLoaf = 5;

    // public Bread(int numOfLoafs)
    // {
    //   numOfLoafs += numOfLoafs;
    // }

    public int ReturnBreadPrice(int numOfLoafs)
    { 
      int finalBreadPrice = 0;
      for (int i = 1; i <= numOfLoafs; i++)
      {
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