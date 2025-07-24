namespace StudentGradeManager;

public class Student
{
    // Property for student ID
    public int ID { get; set; }

    // Property for list of grades
    public List<double> Grades { get; set; }

    // Constructor to initialize Grades list
    public Student()
    {
        Grades = new List<double>(); // Initialize the list
    }
    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    public string Name { get; set; }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }
    public double CalculateAverageGrade()
    {
        return Grades.Count > 0 ? Grades.Average() : 0.0;
    }



    // Method to calculate the average grade
    public double GetAverage()
    {
        return Grades.Count > 0 ? Grades.Average() : 0.0;
    }
   

}