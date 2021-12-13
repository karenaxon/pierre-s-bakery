
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
      Console.Write("\nWhat would you like to add to your cart? [Enter 1 = bread | 2 = pastry]: ");
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

      displayItemsInCart(order);
      string nextChoice = nextChoiceSelection();
      if(nextChoice == "1")
      {
        addMoreToCart(order, bread, pastry);
      } else if (nextChoice == "2")
      {
        //checkout
      }
    }

    public static void displayItemsInCart(Store currentOrder)
    {
      Console.WriteLine("\nItems in your shopping cart:");
      Console.WriteLine("-------------------------------");

      foreach (var item in currentOrder.GetShoppingList())
      {
        string name = item.Key;
        if(item.Value > 1) 
        {
          if(name == "bread")
          {
            Console.WriteLine(item.Value + " loaves of bread");
          } else if(name == "pastry")
          {
            Console.WriteLine(item.Value + " pastries");
          }
        } else
        {
          Console.WriteLine(item.Value + " " + item.Key);
        }
      }
    }

    public static string nextChoiceSelection()
    {
      Console.Write("\nWould you like to add something else to your cart? [Enter 1 = 'yes' | 2 = check out]: ");
      string input = Console.ReadLine();
      return input;
    }

    public static void addMoreToCart(Store theOrder, Bread loaf, Pastry treat)
    {
      string countString2;
      string selection2 = makePurchaseSelection();

      if(selection2 == "1")
      {
        Console.Write("How many loaves of bread would you like to purchase? ");
        countString2 = Console.ReadLine();
        int inputtedCount = int.Parse(countString2);
        int currentCountInCart = 0;
        int updatedCount = 0;

        foreach (var item in theOrder.GetShoppingList())
        {
          if(item.Key != loaf.Name)
          {
            theOrder.AddToShoppingList(loaf.Name, inputtedCount);
            displayItemsInCart(theOrder);
          }else
          {
            currentCountInCart = item.Value;
          }
        }
        updatedCount = inputtedCount + currentCountInCart;
        theOrder.UpdateCount(loaf.Name, updatedCount);
      } else if (selection2 == "2")
      {
        Console.Write("How many pastries would you like to purchase? ");
        countString2 = Console.ReadLine();
        int inputtedCount = int.Parse(countString2);
        int currentCountInCart = 0;
        int updatedCount = 0;

        foreach (var item in theOrder.GetShoppingList())
        {
          if(item.Key != treat.Name)
          {
            theOrder.AddToShoppingList(treat.Name, inputtedCount);
            displayItemsInCart(theOrder);
          }else
          {
            currentCountInCart = item.Value;
          }
        }
        updatedCount = inputtedCount + currentCountInCart;
        theOrder.UpdateCount(treat.Name, updatedCount);
      } else
      {
        Console.WriteLine("Something went wrong.");
        Main();
      }

      displayItemsInCart(theOrder);
      string nextChoice2 = nextChoiceSelection();
      if(nextChoice2 == "1")
      {
        addMoreToCart(theOrder, loaf, treat);
      } else if (nextChoice2 == "2")
      {
        //checkout
      } 
    }
  }
}