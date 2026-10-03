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
        if (courses.Contains(course))
        return; 

        course.Enroll(this);

        if (course.Students.Contains(this ) && !courses.Contains(course))
        {
            courses.Add(course);
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
    public override string ToString()
    {
        return $"{Name} {courses.Count} kurser";
    }
}