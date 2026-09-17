public class Student
{
    public string? Name;
    List<Course> courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        courses.Add(course);
        course.Enroll(this);
    }

     public void Leave(Course course)
    {
        courses.Remove(course);
        course.Students.Remove(this);
    }

     public void Schedule()
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(course.Name);
        }

    }

     
}