namespace ConsoleApp
{
  public enum OrderStatus
  {
    Processing,
    Completed,
    Refunded,
    Failed,
    Canceled,
  }
  public class Order
  {
    private Guid id;
    public Guid Id { get { return id; } private set { } }
    public string fio;
    public OrderStatus status;
    public DateOnly orderDate;
    public string address;
    public double totalCost;
    public List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
      id = Guid.NewGuid();
      fio = customer.fio;
      address = customer.address;
      this.products = products;
      status = OrderStatus.Processing;
      totalCost = Math.Round(products.Sum(product => product.Price), 2);
      orderDate = new DateOnly();
    }

    public void GetInfo()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("\nOrder info");
      Console.WriteLine(
          $"Id: {id}, "
          + $"\nFIO: {fio}, "
          + $"\nstatus: {status}, "
          + $"\norderDate: {orderDate}, "
          + $"\naddress: {address}, "
          + $"\ntotalCost: {totalCost}, "
          + $"\nproducts: {String.Join(", ", products.ConvertAll<string>(product => product.Name + " (" + product.Price + ")").ToArray())}, "
        );
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
