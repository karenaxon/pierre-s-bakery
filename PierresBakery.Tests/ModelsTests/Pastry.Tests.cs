using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void PastryPrice_ReturnsPriceOfAPastry_Double()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(0, pastry.Price);
    }

    [TestMethod]
    public void CalcPrice_ReturnsQuantityPassedIn_Int()
    {
      Pastry pastry = new Pastry();
      pastry.CalcPrice(6);
      Assert.AreEqual(10, pastry.Price);
    }
  }
}
