namespace StudentGradeManager;

class Program
{
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>();


        Student student1 = new Student { ID = 1, Name = "John" };
        student1.AddGrade(90, 85);
        students.Add(student1);

        Student student2 = new Student { ID = 2, Name = "Jane" };
        student2.AddGrade(95, 88);
        students.Add(student2);

        Student student3 = new Student { ID = 3, Name = "Sam" };
        student3.AddGrade(80, 70, 85);
        students.Add(student3);

        Student student4 = new Student { ID = 4, Name = "Lucy" };
        student4.AddGrade(100, 98);
        students.Add(student4);

        
        foreach (var student in students)
        {
            //Console.WriteLine($"Student ID: {student.ID}, Average Grade: {student.CalculateAverageGrade():F2}");
            //Console.WriteLine("Grades: " + string.Join(", ", student.Grades)); //results in all grades displaying
            Console.WriteLine($"Student Name: {student.Name}, ID: {student.ID}");
            Console.WriteLine("Grades: " + string.Join(", ", student.Grades));
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}\n");


        }
        
        
    }
    

}