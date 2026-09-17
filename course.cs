public class Course
{
    
    string Name {get; set;}
    int MaxSeats = 6;
    
    public List<string> Students = new List<string>();
    
    public void Enroll(Course course)
    {
        course.Enroll(this);
    }

}