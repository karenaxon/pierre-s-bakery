using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
  [TestClass]
  public class StoreTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread("bread");
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry("bread");
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void BreadPrice_ReturnsPriceOfABread_Double()
    {
      Bread bread = new Bread("bread");
      Assert.AreEqual(5.00, bread.Price);
    }

    [TestMethod]
    public void PastryPrice_ReturnsPriceOfAPastry_Double()
    {
      Pastry pastry = new Pastry("pastry");
      Assert.AreEqual(2.00, pastry.Price);
    }

    [TestMethod]
    public void ShoppingListDictionary_VerifyBreadIsAdded_Int()
    {
      Bread bread = new Bread("bread");
      Store order = new Store();
      order.AddToShoppingList(bread.Name, 1);
      Dictionary<string, int> currentOrder = order.GetShoppingList();
      Assert.AreEqual(1, currentOrder["bread"]);
    }

    [TestMethod]
    public void ShoppingListDictionary_VerifyPastryIsAdded_Int()
    {
      Pastry pastry = new Pastry("pastry");
      Store order = new Store();
      order.AddToShoppingList(pastry.Name, 3);
      Dictionary<string, int> currentOrder = order.GetShoppingList();
      Assert.AreEqual(3, currentOrder["pastry"]);
    }

    [TestMethod]
    public void UpdateCount_VerifyBreadCountUpdates_Int()
    {
      Bread bread = new Bread("bread");
      Store order = new Store();
      Dictionary<string, int> currentOrder = order.GetShoppingList();
      order.AddToShoppingList(bread.Name, 3);
      int addItems = 2;
      order.UpdateCount(bread.Name, addItems);
      Assert.AreEqual(3, currentOrder[bread.Name]);
    }
  }
}
