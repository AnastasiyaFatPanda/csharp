class Program
{
  static void Main()
  {
    Employee[] employees = {
      new Employee("Ivanov Ivan", new DateOnly(1995, 6, 6)),
      new Employee("Krav Kristina", Gender.Female, new DateOnly(1985, 11, 29), new DateOnly(2020, 1, 10), 1500),
      new Employee("Grachova Iryna", Gender.Female, new DateOnly(1995, 12, 6)),
      new Employee("Som Aleksandra", Gender.Female, new DateOnly(1998, 7, 23), new DateOnly(2020, 1, 10), 1500.01),
      new Employee("Gorkiy Maksim", Gender.Male, new DateOnly(1985, 11, 29), new DateOnly(1999, 3, 15), 5500.75),
      new Employee("Pushkin Alexandr", Gender.Male, new DateOnly(1977, 10, 9), new DateOnly(2000, 12, 1), 3500.8),
    };


    foreach (Employee employee in SortEmployees(employees, SortBy.Salary))
      employee.GetInfo();

    foreach (Employee employee in SortEmployees(employees, SortBy.Name))
      employee.GetInfo();

    foreach (Employee employee in SortEmployees(employees, SortBy.DayOfBirth))
      employee.GetInfo();

    Console.ReadKey();

    static Employee[] SortEmployees(Employee[] arr, SortBy sortBy)
    {
      switch (sortBy)
      {
        case SortBy.Salary:
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Sort by Salary: \n");
          Array.Sort(arr, (Employee x, Employee y) => x.salary.CompareTo(y.salary));
          return arr;
        case SortBy.Name:
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("\n\nSort by Name: \n");
          Array.Sort(arr, (Employee x, Employee y) => x.fio.CompareTo(y.fio));
          return arr;
        case SortBy.DayOfBirth:
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("\n\nSort by DayOfBirth: \n");
          Array.Sort(arr, (Employee x, Employee y) => x.dayOfBirth.CompareTo(y.dayOfBirth));
          return arr;
        default:
          return arr;
      }
    }
  }
}
