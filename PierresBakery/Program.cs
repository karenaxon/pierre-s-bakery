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
        System.Console.WriteLine("\nWelcome to Pierre's Bakery");
        System.Console.WriteLine("---------------------------");
        start = false;
      } 
      displayPrices();
    
    }

    public static void displayPrices()
    {
      System.Console.WriteLine("Menu and prices:\n");
      System.Console.WriteLine("BREAD");
      System.Console.WriteLine("1 loaf     $5\n2 loaves   $10\n3 loaves   $10 (get one free!)\n");
      System.Console.WriteLine("PASTRIES");
      System.Console.WriteLine("1 pastry   $2\n3 pastries $5\n4 pastries $7\n5 pastries $9\n6 pastries $10\n");
    }
  }
    
}