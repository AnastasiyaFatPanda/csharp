namespace ConsoleApplication
{
  public enum Gender { Male, Female }
  public enum SortBy { Salary, Name, DayOfBirth }
  public class Employee
  {
    public string fio;
    public Gender gender;
    public DateOnly dayOfBirth;
    public DateOnly startDate;
    public double salary;
    public Employee(string fio, DateOnly dayOfBirth) : this(fio, Gender.Male, dayOfBirth, DateOnly.FromDateTime(DateTime.Today), 1000) { }
    public Employee(string fio, Gender gender, DateOnly dayOfBirth) : this(fio, gender, dayOfBirth, DateOnly.FromDateTime(DateTime.Today), 1000) { }

    public Employee(string fio, Gender gender, DateOnly dayOfBirth, DateOnly startDate, double salary)
    {
      this.fio = fio;
      this.gender = gender;
      this.dayOfBirth = dayOfBirth;
      this.startDate = startDate;
      this.salary = salary;
    }

    public void GetInfo()
    { 
      Console.WriteLine(
        $"FIO: {this.fio}, "
        + $"Gender: {this.gender}, "
        + $"Day of Birth: {this.dayOfBirth}, "
        + $"Start Date: {this.startDate} "
        + $"Salary: {this.salary}$;"
      );
    }
  }
}