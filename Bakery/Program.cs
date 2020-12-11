using Bakery.Models;
using System;

namespace Bakery
{
  class Program
  {
    public static Bread breadOrder = new Bread();
    public static Pastry pastryOrder = new Pastry();
    public static void Main()
    {
      Console.WriteLine("Welcome to Pretty Baked Bakery!");
      Console.WriteLine("Would you like to place a bread or pastry order? Please type 'bread' or 'pastry'.");
      string userInput = Console.ReadLine();
      if (userInput.Equals("bread"))
      {
        ShowBreadOrder();
      }
      else if (userInput.Equals("pastry"))
      {
        ShowPastryOrder();
      }
      else 
      {
        Main();
      } 

      // BREAD ORDER
      public static void ShowBreadOrder(int )
      {

      }

      // PASTRY ORDER
      public static void ShowPastryOrder()
      {

      }


      
      // int orderTotal = 0;
    }
  }
}