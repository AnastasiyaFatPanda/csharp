namespace ConsoleApplication
{
    public class Mark
    {
        public string subject;
        public int grade;

        public Mark(string subject, int grade)
        {
            this.subject = subject;
            this.grade = grade;
        }
    }

    public class Student
    {
        private string fio;
        private int age;
        private Mark[] marks;


        public Student(string fio, int age, Mark[] marks)
        {
            this.fio = fio;
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

             Console.WriteLine($"FIO: {this.fio}, " +$"Age: {this.age}, " + $"Marks: {grades} ");
        }
        public float GetAvgMark()
        {
            if (this.marks.Length == 0)
            {
                Console.WriteLine("No marks");
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < this.marks.Length; i++)
            {
                sum += this.marks[i].grade;
            }

            Console.WriteLine($"Average mark is {sum / marks.Length}");
            return sum / this.marks.Length;
        }

        public void ResetAllMarks()
        {
            Console.WriteLine("Delete all marks");
            for     (int i = 0; i < this.marks.Length; i++)
            {
                this.marks[i].grade = 0;
            }
            
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student("Ivanov Ivan Ivanovich", 24, new Mark[]{ new Mark("math", 10), new Mark("chemistry", 7), new Mark("english", 8) });
            
            student.GetInfo();
            student.GetAvgMark();
            student.ResetAllMarks();
            student.GetInfo();
            student.GetAvgMark();
            Console.ReadKey();
        }
    }

}
