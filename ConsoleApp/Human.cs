using System.Reflection;

namespace ConsoleApp
{
  public enum Gender { Male, Female }
  public class Human
  {
    private string name;
    private int age;
    public bool testFieldForTypeInfo;
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
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
          throw new Exception("You cannot set age less than 0 and greater than 100;");
        }
      }
    }
    public virtual Gender Gender { get; }

    public Human(string name = "Noname", int age = 1, Gender gender = Gender.Male)
    {
      Name = name;
      Age = age;
      Gender = gender;
    }

    public virtual void WhoAmI()
    {
      Console.WriteLine("I'm a human");
    }
    public void GetInfo()
    {
      string info = "";
      foreach (PropertyInfo prop in this.GetType().GetProperties())
      {
        info += $"{prop.Name}: {prop.GetValue(this, null)}; ";
      }
      Console.WriteLine(info);
    }
  }

  public class Boy : Human
  {
    public string SportClub { get; set; }
    public override Gender Gender
    {
      get => Gender.Male;
    }

    public Boy(string name, int age, string sportClub = "No sport clubs") : base(name, age, Gender.Male)
    {
      SportClub = sportClub;
    }
    public override void WhoAmI()
    {
      Console.WriteLine("I'm a boy");
    }

    public void PlayFootbal()
    {
      Console.WriteLine("Boy is playing football");
    }
  }

  public class Girl : Human
  {
    public string Adress { get; set; }
    public bool testFieldForTypeInfoGirl;
    public override Gender Gender
    {
      get => Gender.Female;
    }
    public Girl(string name, int age, string address) : base(name, age, Gender.Female)
    {
      Adress = address;
    }
    public override void WhoAmI()
    {
      Console.WriteLine("I'm a girl");
    }

    public void PlayPiano()
    {
      Console.WriteLine("Girl is playing the piano");
    }

  }
}
