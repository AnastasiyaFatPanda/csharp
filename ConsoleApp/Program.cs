namespace ConsoleApplication
{
  public class Mark
  {
    public string subject;
    public int grade;

    public Mark(string subject) : this(subject, 0) { }

    public Mark(string subject, int grade)
    {
      this.subject = subject;
      this.grade = grade;
    }
  }
  public enum Gender { Male, Female }
  public class Student
  {
    private string fio;
    private int age;
    public Gender gender;
    private Mark[] marks;

    public Student(string fio, int age, Mark[] marks) : this(fio, Gender.Male, age, marks) { }

    public Student(string fio, Gender gender, int age, Mark[] marks)
    {
      this.fio = fio;
      this.gender = gender;
      this.age = age;
      this.marks = marks;
    }

    public void GetInfo()
    {
      string grades = "";

      foreach (var mark in marks)
      {
        grades += $"{mark.subject} - {mark.grade}; ";
      }

      Console.WriteLine($"FIO: {this.fio}, " + $"Gender: {this.gender}, " + $"Age: {this.age}, " + $"Marks: {grades} ");
    }
    public float GetAvgMark()
    {
      if (marks.Length == 0)
      {
        Console.WriteLine("No marks");
        return 0;
      }

      var sum = 0;
      for (int i = 0; i < marks.Length; i++)
      {
        sum += marks[i].grade;
      }

      Console.WriteLine($"Average mark is {sum / marks.Length} for {fio}");
      return sum / marks.Length;
    }

    public void ResetAllMarks(int resetMark = 0)
    {
      Console.WriteLine($"Reset all marks to {resetMark} for {fio}");
      for (int i = 0; i < marks.Length; i++)
      {
        marks[i].grade = resetMark;
      }

    }
  }

  class Program
  {
    static void Main()
    {
      Student student = new Student("Ivanov Ivan Ivanovich", 24, new Mark[] { new Mark("math"), new Mark("chemistry", 9), new Mark("english", 8) });
      Student student2 = new Student("Ivanova Olha Ivanovna", Gender.Female, 20, new Mark[] { new Mark("math"), new Mark("chemistry", 4), new Mark("english", 8) });

      student.GetInfo();
      student.GetAvgMark();
      student.ResetAllMarks(8);
      student.GetInfo();
      student2.ResetAllMarks();
      student2.GetInfo();
      student2.GetAvgMark();
      Console.ReadKey();
    }
  }

}
