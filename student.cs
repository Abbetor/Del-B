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
        if(courses.Contains(course) == false)
        {
            courses.Add(course);
            course.Enroll(this);
        }
    }   

     public void Leave(Course course)
    {   
        if(courses.Contains(course))
        {
            courses.Remove(course);
            course.Remove(this);
        }
    }   

     public void Schedule()
    {
        foreach (Course course in courses)
        {
            Console.WriteLine($"Har lagt till {course.Name}");
        }

    }

}