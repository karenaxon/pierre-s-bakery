using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Store
  {
    public Dictionary<object, int> shoppingList { get; set; }

    public Store()
    {
      shoppingList = new Dictionary<object, int>();
    }

    public void AddToShoppingList(object item, int quantity)
    {
      shoppingList.Add(item, quantity);
    }

    public static Dictionary<object, int> GetShoppingList()
    {
      return shoppingList;
    }

    // public static void DisplayShoppingList()
    // {
    //   for
    // }

    

  


  }

}