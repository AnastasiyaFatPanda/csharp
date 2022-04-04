namespace ConsoleApplication
{
  public enum Gender { Male, Female }
  public class Customer
  {
    public string fio;
    public string address;
    public Gender gender;
    public DateOnly dayOfBirth;

    public Customer(string fio,string address, Gender gender, DateOnly dayOfBirth)
    {
      this.fio = fio;
      this.address = address;
      this.gender = gender;
      this.dayOfBirth = dayOfBirth;
    }

    public void GetInfo()
    {
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("\n\nCustomer info");
      Console.WriteLine(
        $"FIO: {this.fio}, "
        + $"Gender: {this.gender}, "
        + $"Day of Birth: {this.dayOfBirth}, "
      );
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}