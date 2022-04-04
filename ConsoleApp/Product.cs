namespace ConsoleApp
{
  public class Product
  {
    string name;
    double price;
    public string Name
    {
      get { return name; }
      set
      {
        if (value.Length > 0)
        {
          name = value;
        }
        else
        {
          throw new Exception("The Product must has a name;");
        }
      }
    }
    public double Price
    {
      get { return price; }
      set
      {
        if (value > 0)
        {
          price = value;
        }
        else
        {
          throw new Exception("The Product must has a correct price value;");
        }
      }
    }

    public Product(string name, double price)
    {
      Name = name;
      Price = price;
    }
  }

  public class Toy : Product
  {
    int age;
    public int Age
    {
      get { return age; }
      set
      {
        if (value > 0 && value < 100)
        {
          age = value;
        }
        else
        {
          throw new Exception("Age must be greater than 0 and less than 100");
        }
      }
    }

    public Toy(string name, double price, int age) : base(name, price)
    {
      Age = age;
    }
  }

  public enum CoverType { Softcover, Hardcover }
  public class Book : Product
  {
    public string author;
    public int totalPages;
    public CoverType cover;
    public string publishingHouse;

    public Book(string name, double price, string author, int totalPages, CoverType cover, string publishingHouse) : base(name, price)
    {
      this.author = author;
      this.totalPages = totalPages;
      this.cover = cover;
      this.publishingHouse = publishingHouse;
    }
  }
}
