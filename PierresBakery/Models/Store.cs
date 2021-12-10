using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Store
  {
    public static List<object> orderItemsList = new List<object>{};

    public Store(object item)
    {
      orderItemsList.Add(this);
    }

    public static void DisplayList()
    {
      for(int i = 0; i < orderItemsList.Count; i++) 
      {
        System.Console.WriteLine(item);
      }
    }

  }

}