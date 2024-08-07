namespace Advanced_csharp_assing;

public class Student : IComparable<Student>
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Student(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public int CompareTo(Student other)
    {
        return ID.CompareTo(other.ID);
    }

    public override string ToString()
    {
        return $"{Name} (ID: {ID})";
    }
}
