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

}
