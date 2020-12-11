using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery
{
  class Program
  {
    public static Bread breadOrder = new Bread();
    public static Pastry pastryOrder = new Pastry();
    public static void Main()
    {
      int finalPrice = 0;
      Console.WriteLine("Welcome to Pretty Baked Bakery!");
      OrderMenu(finalPrice);
    }
    public static void OrderMenu(int finalPrice)
    {
      Console.WriteLine("Would you like to place a bread or pastry order? Please type 'bread' or 'pastry'.");
      string userInput = Console.ReadLine();
      if (userInput.Equals("bread"))
      {
        ShowBreadOrder(finalPrice);
      }
      else if (userInput.Equals("pastry"))
      {
        ShowPastryOrder(finalPrice);
      }
      else
      {
        Main();
      }
    }  
      // BREAD ORDER
      public static void ShowBreadOrder(int finalPrice)
      {
        Console.WriteLine("How many loafs would you like to order?");
        int numOfLoafs = int.Parse(Console.ReadLine());
        Bread newLoaf = new Bread();
        int finalBreadPrice = newLoaf.ReturnBreadPrice(numOfLoafs);
        Console.WriteLine("Your total is: $ " + finalBreadPrice * numOfLoafs);
      }

      // PASTRY ORDER
      public static void ShowPastryOrder(int finalPrice)
      {
        Console.WriteLine("How many pastries would you like to order?");
        int numOfPastries = int.Parse(Console.ReadLine());
        Pastry newPastry = new Pastry();
        int finalPastryPrice = newPastry.ReturnPastryPrice(numOfPastries);
        Console.WriteLine("Your total is: $ " + finalPastryPrice);
      }


      
  }
}
