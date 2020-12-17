using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery
{
  class Program
  {
    public static Bread breadOrder = new Bread(5);
    public static Pastry pastryOrder = new Pastry(2);
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
      // // BREAD ORDER
    public static void ShowBreadOrder(int finalPrice)
    {
      Console.WriteLine("SPECIAL OFFER! BUY 2 LOAFS, GET 1 FREE!");
      Console.WriteLine("One loaf of bread = $5.00");
      Console.WriteLine("How many loafs would you like to order?");

      int numOfLoafs = int.Parse(Console.ReadLine());
      Bread newLoaf = new Bread(5);        
      int breadPrice = newLoaf.FinalPrice(numOfLoafs);
      int totalBreadPrice = breadPrice * numOfLoafs;
      if(numOfLoafs.Equals(2))
      {
        Console.WriteLine("Hope you like bread, because you are getting a loaf for free!");
        Console.WriteLine("Your total is: $ " + totalBreadPrice);
        Console.WriteLine("Thanks for coming to Pretty Baked Bakery, have an awesome day!");
      }
      else if (numOfLoafs.Equals(3))
      {
        Console.WriteLine("Thanks for your business, enjoy this discount!");
        Console.WriteLine("Your total is: " + (totalBreadPrice - 5));
      }
      else
      {
        Console.WriteLine("Your total is: $ " + totalBreadPrice);
        Console.WriteLine("Thanks for coming to Pretty Baked Bakery, have an awesome day!");
      }
    }

      // // PASTRY ORDER
    public static void ShowPastryOrder(int finalPrice)
    {
      Console.WriteLine("One pastry = $2.00");
      Console.WriteLine("SPECIAL OFFER: Get 3 pastries for $5.00!");
      Console.WriteLine("How many pastries would you like to order?");

      int numOfPastries = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(2);
      int pastryPrice = newPastry.GetPastryPrice(numOfPastries);
      int totalPastryPrice = pastryPrice * numOfPastries;
      if(numOfPastries.Equals(3))
      {
        Console.WriteLine("Thanks for your business, enjoy this discount!");
        Console.WriteLine("Your total is: " + (totalPastryPrice -1));
      }
      else
      {
        Console.WriteLine("Your total is: $ " + totalPastryPrice);
        Console.WriteLine("Thanks for coming to Pretty Baked Bakery, have an awesome day!");
      }
    }  
  }
}