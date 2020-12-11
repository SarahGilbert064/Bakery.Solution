using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NewLoaf { get; set; }
    public int PriceOfLoaf = 5;

    public int ReturnPrice(int numOfLoafs)
    {
      int loafPrice = 0;
      for (int i = 1; i <= numOfLoafs; i++)
      {
        if(i == 1)
        {
          loafPrice+=5;
        }
        else
        {
          loafPrice += 0;
        }
      }
      return loafPrice;
    }
  }
}