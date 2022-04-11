namespace ConsoleApp
{
  public enum Gender { Male, Female }
  public interface IAnimal
  {
    string Name { get; set; }
    int Age { get; set; }
    Gender Gender { get; set; }
    double Weight { get; set; }
    void Move();
  }

  interface IFly
  {
    void Fly();
  }

  public class Animal : IAnimal
  {
    private string name;
    private int age;
    private double weight;
    private Gender gender;
    public string Name {
      get { return name; }
      set { name = value.Length > 0 ? value : "Noname"; } 
    }
    public int Age
    {
      get { return age; }
      set
      {
        if (value > 0 && value < 50)
        {
          age = value;
        }
        else
        {
          throw new Exception("You cannot set age less than 0 and greater than 50;");
        }
      }
    }
    public Gender Gender
    {
      get { return gender; }
      set { gender = value; }
    }
    public double Weight
    {
      get { return weight; }
      set
      {
        if (value > 0)
        {
          weight = value;
        }
        else
        {
          throw new Exception("You cannot set weight less than 0;");
        }
      }
    }

    public Animal(string name, int age, Gender gender, double weight)
    {
      Name = name;
      Age = age;
      Weight = weight;
      Gender = gender;
    }

    public void Move()
    {
      Console.WriteLine($"{this.Name} is moving...");
    }
  }

  public class Dog : Animal
  {
    public Dog(string name, int age, Gender gender, double weight) : base(name, age, gender, weight)
    {
    }

    public void Bark()
    {
      Console.WriteLine("Woof!");
    }
  }

  public class Cat : Animal
  {
    public Cat(string name, int age, Gender gender, double weight) : base(name, age, gender, weight)
    {
    }

    public void Purring()
    {
      Console.WriteLine("Mrr...");
    }
  }

  public enum WingType
  {
    Elliptical,
    Hovering,
    HighSpeed,
    ActiveSoaring,
    PassiveSoaring,
    Flightless
  }

  public class Bird : Animal
  {
    public Bird(string name, int age, Gender gender, double weight) : base(name, age, gender, weight)
    {
    }

    public WingType Wing { get; set; }
  }

  public class Eagle : Bird, IFly
  {
    public WingType Wing
    {
      get { return WingType.PassiveSoaring; }
      private set { }
    }

    public Eagle(string name, int age, Gender gender, double weight) : this(name, age, gender, weight, WingType.Flightless) { }
    public Eagle(string name, int age, Gender gender, double weight, WingType wing) : base(name, age, gender, weight)
    {
      Name = name;
      Age = age;
      Weight = weight;
      Gender = gender;
      Wing = wing;
    }

    public void Fly()
    {
      Console.WriteLine("Eagle is flying!");
    }
  }

  public class Penguin : Bird
  {
    public WingType Wing
    {
      get { return WingType.Flightless; }
      private set { }
    }

    public Penguin(string name, int age, Gender gender, double weight) : this(name, age, gender, weight, WingType.Flightless) { }

    public Penguin(string name, int age, Gender gender, double weight, WingType wing) : base(name, age, gender, weight)
    {
      Name = name;
      Age = age;
      Weight = weight;
      Gender = gender;
      Wing = wing;
    }

    public void Dive()
    {
      Console.WriteLine("Penguin is diving!");
    }

  }
}
