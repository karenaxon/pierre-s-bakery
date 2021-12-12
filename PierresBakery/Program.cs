using System.Collections.Generic;
using System.Reflection;
using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static bool start = true;

    public static void Main()
    {
      if (start)
      {
        Console.WriteLine("\nWelcome to Pierre's Bakery");
        Console.WriteLine("---------------------------");
        start = false;
      } 

      displayPrices();
      initOrder();
    }

    public static void displayPrices()
    {
      Console.WriteLine("Menu and prices:\n");
      Console.WriteLine("BREAD");
      Console.WriteLine("1 loaf     $5\n2 loaves   $10\n3 loaves   $10 (get one free!)\n");
      Console.WriteLine("PASTRIES");
      Console.WriteLine("1 pastry   $2\n3 pastries $5\n4 pastries $7\n5 pastries $9\n6 pastries $10\n");
    }

    public static string makePurchaseSelection()
    {
      Console.Write("\nWhat would you like to purchase? [Enter 1 for bread or 2 for pastries]: ");
      string selection = Console.ReadLine();

      if(selection == "1" || selection == "2")
      {
        return selection;
      } else
      {
        Console.WriteLine("\n**** Invalid input ****");
        makePurchaseSelection();
      }
      return selection;
    }

    public static void initOrder()
    {
      Bread bread = new Bread("bread");
      Pastry pastry = new Pastry("pastry");
      Store order = new Store();
      string countString;
      int count;
      string selection = makePurchaseSelection();

      if(selection == "1")
      {
        Console.Write("How many loaves of bread would you like to purchase? ");
        countString = Console.ReadLine();
        count = int.Parse(countString);
        order.AddToShoppingList(bread.Name, count);
      } else if (selection == "2")
      {
        Console.Write("How many pastries would you like to purchase? ");
        countString = Console.ReadLine();
        count = int.Parse(countString);
        order.AddToShoppingList(pastry.Name, count);
      } else
      {
        Console.WriteLine("Something went wrong.");
        Main();
      } 

      foreach (var item in order.GetShoppingList())
      {
        Console.WriteLine(item.Value + " " + item.Key + " have been added to your list.");
      }
    }
  }
}