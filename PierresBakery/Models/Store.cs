using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Store
  {
    static List<object> order = new List<object>();
  }

  static void DisplayList()
  {
    for(int i = 0; i < order.Count; i++)
    {
      System.Console.WriteLine(order[i]);
    }
  }
}