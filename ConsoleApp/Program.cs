class Program
{
  static void Main()
  {
    Customer customer = new Customer("Ivanov Ivan", "Some Address 44", Gender.Male, new DateOnly(1989, 11, 3));
    Book book = new Book("Nefritovye Chetki", 17.7, "Boris Akunin", 704, CoverType.Softcover, "AST");
    Book book2 = new Book("Dekorator", 21.7, "Boris Akunin", 556, CoverType.Hardcover, "AST");
    Toy toy = new Toy("Doll", 57.8, 3);
    Storage storage = new Storage();
    storage.cells.Add(new StorageCell(book, 10));
    storage.cells.Add(new StorageCell(book2, 1));
    storage.cells.Add(new StorageCell(toy, 100));
    Shop shop = new Shop("All sorts of little things", storage);
    // get info about shop with storage and no orders
    shop.GetInfo();
    Order order = new Order(customer, new List<Product> { book, book2, toy });
    Order order2 = new Order(customer, new List<Product> { book2, book2 });
    //create an order
    shop.CreateOrder(order);
    shop.GetInfo();
    // create an order
    shop.CreateOrder(order2);
    // add products to shop's storage
    shop.AddProduct(book2, 6);
    // create an order
    shop.CreateOrder(order2);
    shop.GetInfo();
    // complete order and get order info
    Console.WriteLine("\nComplete order and get order info");
    shop.GetOrder(shop.orders.ToArray()[0].Id).status = OrderStatus.Completed;
    shop.GetOrder(shop.orders.ToArray()[0].Id).GetInfo();

    // create product with incorrect cost
    //Book book4 = new Book("Dekorator2", -26.7, "Boris Akunin", 56, CoverType.Hardcover, "AST");
  }
  internal class Shop
  {
    public string name;
    public Storage storage;
    public List<Order> orders;

    public Shop(string name) : this(name, new Storage(), new List<Order>()) { }
    public Shop(string name, Storage storage) : this(name, storage, new List<Order>()) { }
    public Shop(string name, Storage storage, List<Order> orders)
    {
      this.name = name;
      this.storage = storage;
      this.orders = orders;
    }

    public void CreateOrder(Order orderInfo)
    {
      if (orderInfo.products.All(p => storage.cells.Find(cell => cell.product.Name == p.Name)?.count > 0))
      {
        orderInfo.products.ForEach(product => this.DeleteProduct(product));
        orders.Add(orderInfo);
        Console.WriteLine("\nOrder was created:");
        orderInfo.GetInfo();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nCannot create an order, there are not enough products in storage");
        Console.ForegroundColor = ConsoleColor.White;
      }
    }

    public void AddProduct(Product newProduct, int count)
    {
      if (storage.cells.Exists(cell => cell.product.Name == newProduct.Name))
      {
        storage.cells.Find(cell => cell.product.Name == newProduct.Name).count += count;
      }
      else
      {
        storage.cells.Add(new StorageCell(newProduct, count));
      }
      Console.WriteLine($"\n{count} {newProduct.Name}(s) was\\were added.");
    }

    public void DeleteProduct(Product product)
    {
      storage.cells.Find(cell => cell.product.Name == product.Name).count--;
    }

    public Order GetOrder(Guid orderId)
    {
      return orders.Find(x => x.Id == orderId);
    }

    public void GetInfo()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(
        $"\nShop Info \nName: {name}, "
        + $"Orders: {orders.Count} "
        + $"{(orders.Count > 0 ? String.Join(", ", orders.ConvertAll<Guid>(order => order.Id).ToArray()) : null)},"
        + "Storage:");
      storage.GetInfo();
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
