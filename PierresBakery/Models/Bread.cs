namespace PierresBakery.Models
{
  public class Bread
  {
    public double Price { get; set; }
    public string Name { get; set; }

    public Bread(string name)
    {
      Name = name;
      Price = 5.00;
    }
  }
}