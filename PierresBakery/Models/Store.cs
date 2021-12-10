using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Store
  {
    public static List<object> shoppingList { get; set; }

    public Store()
    {
      shoppingList = new List<object>();
    }

    public void AddToShoppingList(object item)
    {
      shoppingList.Add(item);
    }

    public void DisplayList()
    {
      for(int i = 0; i < shoppingList.Count; i++)
      {
        System.Console.WriteLine(shoppingList[i]);
      }
    }
  }

}