namespace ConsoleApplication
{
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

}
