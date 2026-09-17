public class Course
{
    public string Name { get; set; }
    public int MaxSeats = 6;
    public List<Student> Students = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void Enroll(Student student)
    {
        if (Students.Count < MaxSeats)
        {
            Students.Add(student);
        }
    }
    public void Remove(Student student)
    {
        Students.Remove(student);
    }

    public void Rollcall()
    {
        foreach(Student student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }

}

