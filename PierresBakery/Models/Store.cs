using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Store
  {
    public static Dictionary<string, int> shoppingList { get; set; }

    public Store()
    {
      shoppingList = new Dictionary<string, int>();
    }

    public void AddToShoppingList(string item, int quantity)
    {
      shoppingList.Add(item, quantity);
    }

    public Dictionary<string, int> GetShoppingList()
    {
      return shoppingList;
    }

    public void UpdateCount(string name, int count)
    {
      shoppingList[name] = count;
    }


  }

}