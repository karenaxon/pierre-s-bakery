using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
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
      makePurchaseSelection();
    
    }

    public static void displayPrices()
    {
      Console.WriteLine("Menu and prices:\n");
      Console.WriteLine("BREAD");
      Console.WriteLine("1 loaf     $5\n2 loaves   $10\n3 loaves   $10 (get one free!)\n");
      Console.WriteLine("PASTRIES");
      Console.WriteLine("1 pastry   $2\n3 pastries $5\n4 pastries $7\n5 pastries $9\n6 pastries $10\n");
    }

    public static void makePurchaseSelection()
    {
      Console.WriteLine("What would you like to purchase?");
      Console.WriteLine("Enter 1 for bread\nEnter 2 for pastries");
      string input = Console.ReadLine();
      int selection = int.Parse(input);

      if(selection == 1)
        {
          // create bread and count input
          Console.WriteLine("CREATE BREAD");
        } else if (selection == 2)
        {
          // create pasty and count input
          Console.WriteLine("CREATE PASTRY");
        } else
        {
          Console.WriteLine("\n**** Invalid input ****\n");
          makePurchaseSelection();
        }
    
    }

  }
}