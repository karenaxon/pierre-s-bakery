
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

    public static void initOrder()
    {
      string countString;
      int count;

      Console.Write("How many loaves of bread would you like to purchase? ");
      countString = Console.ReadLine();
      count = int.Parse(countString);
      Bread bread = new Bread();
      count = 0;
    
      Console.Write("How many pastries would you like to purchase? ");
      countString = Console.ReadLine();
      count = int.Parse(countString);
      Pastry pastry = new Pastry();
    }
  }
}