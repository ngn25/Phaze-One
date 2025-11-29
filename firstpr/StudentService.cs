public class StudentService
{
    private Dictionary<string, Student > Data=new Dictionary<string, Student >();

    public void Add(Student student)
    {
        if (!Data.ContainsKey(student.Id))
        {
            Data.Add(student.Id,student);
        }
    }

    public Student GetById(string Id)
    {
        if (Data.ContainsKey(Id))
        {
            return Data[Id];
    
        }
        return null;
    }
     public List<Student> GetAll()
    {
        return Data.Values.ToList();
    }

    public void Update(Student student)
    {
        if (Data.ContainsKey(student.Id))
        {
            Data [student.Id]=student;
    
        }
    }
    public void DeletById(string Id)
    {
        Data.Remove(Id);
    }
}

















































