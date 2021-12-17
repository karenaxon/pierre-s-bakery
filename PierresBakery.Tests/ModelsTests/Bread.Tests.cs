using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread();
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void BreadPrice_ReturnsPriceOfABread_Double()
    {
      Bread bread = new Bread();
      Assert.AreEqual(0, bread.Price);
    }

    [TestMethod]
    public void CalcPrice_ReturnsQuantityPassedIn_Int()
    {
      Bread bread = new Bread();
      bread.CalcPrice(2);
      Assert.AreEqual(2, bread.Quantity);
    }

    [TestMethod]
    public void CalcPrice_ReturnsPriceForTwo_Double()
    {
      Bread bread = new Bread();
      bread.CalcPrice(2);
      Assert.AreEqual(10.00, bread.Price);
    }

    [TestMethod]
    public void CalcPrice_ReturnsPriceForThree_Double()
    {
      Bread bread = new Bread();
      bread.CalcPrice(3);
      Assert.AreEqual(10.00, bread.Price);
    }
  }
}
