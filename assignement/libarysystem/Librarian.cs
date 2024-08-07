namespace libarysystem;

public class Librarian
{
    public Librarian(int emp_id , string name)
    {
        Emp_ID =emp_id;
        Name = name ;
    }

    public int Emp_ID { get; set; }
    public string Name { get; set; }

}
