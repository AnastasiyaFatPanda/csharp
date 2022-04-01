namespace ConsoleApp
{
  public class StorageCell
  {
    public Product product;
    public int count;

    public StorageCell(Product product) : this(product, 1) { }
    public StorageCell(Product product, int count)
    {
      this.product = product;
      this.count = count;
    }

    public void GetInfo()
    {
      Console.WriteLine($"  Product: {product.Name}, " + $"Count: {count}, ");
    }
  }

  public class Storage
  {
    public List<StorageCell> cells = new List<StorageCell>();

    public void GetInfo()
    {
      if (cells.Count == 0)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No cells");
        Console.ForegroundColor = ConsoleColor.White;
      }
      else
      {
        cells.ForEach(cell => cell.GetInfo());
      }
    }
  }
}
