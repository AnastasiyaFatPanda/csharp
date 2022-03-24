namespace ConsoleApplication
{
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
