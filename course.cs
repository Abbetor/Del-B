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
        if (Students.Contains(student))
        {
        
        }
        else if (Students.Count >= MaxSeats)
        {
            Console.WriteLine(Name + " är full");
        }
        else
        {
            Students.Add(student);
            student.Join(this);
        }
    }
    public void Remove(Student student)
    {
        if (Students.Contains(student))
        {
            Students.Remove(student);
            student.Leave(this);
        }
    }

    public void Rollcall()
    {
        foreach(Student student in Students)
        {
            Console.WriteLine($"Kursdeltagare: {student.Name}");
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }

}

