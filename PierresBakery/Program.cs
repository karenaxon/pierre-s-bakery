
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

      string countString;
      int breadCount;
      int pastryCount;

      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      displayPrices();

      Console.Write("How many loaves of bread would you like to purchase? ");
      countString = Console.ReadLine();
      breadCount = int.Parse(countString);
      bread.CalcPrice(breadCount);

      Console.Write("How many pastries would you like to purchase? ");
      countString = Console.ReadLine();
      pastryCount = int.Parse(countString);
      pastry.CalcPrice(pastryCount);

      Console.WriteLine("\n**** YOUR BILL: ****\n");
      if(breadCount > 1)
      {
        if(breadCount % 3 == 0)
        {
          Console.WriteLine($"{@breadCount} loaves of bread = ${@bread.Price} (each 3rd loaf is free!)");
        } else
        {
          Console.WriteLine($"{@breadCount} loaves of bread = ${@bread.Price}");  
        }
      } else 
      {
        Console.WriteLine($"{@breadCount} loaf of bread = ${@bread.Price}");
      }

      if(pastryCount > 1)
      {
        if(pastryCount >= 3 && pastryCount <= 5)
        {
          Console.WriteLine($"{@pastryCount} pastries = ${@pastry.Price} (You got a $1 discount!)");
        } else if(pastryCount == 6)
        {
          Console.WriteLine($"{@pastryCount} pastries = ${@pastry.Price} (You got a $2 discount!)");
        } else
        {
          Console.WriteLine($"{@pastryCount} pastries = ${@pastry.Price}");
        }
      } else
      {
          Console.WriteLine($"{@pastryCount} pastry = ${@pastry.Price}");
      }

      Console.WriteLine("-----------------------------");
      Console.WriteLine($"YOUR TOTAL IS:     ${@bread.Price + pastry.Price}");
    }

    public static void displayPrices()
    {
      Console.WriteLine("Menu and prices:\n");
      Console.WriteLine("BREAD");
      Console.WriteLine("1 loaf     $5\n2 loaves   $10\n3 loaves   $10 (get one free!)\n");
      Console.WriteLine("PASTRIES");
      Console.WriteLine("1 pastry   $2\n3 pastries $5\n4 pastries $7\n5 pastries $9\n6 pastries $10\n");
    }
  }
}