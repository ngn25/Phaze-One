public class CourseService
{
    private Dictionary<string, Course > Data=new Dictionary<string, Course >();

    public void Add(Course course)
    {
        if (!Data.ContainsKey(course.Id))
        {
            Data.Add(course.Id,course);
        }
    }

    public Course GetById(string Id)
    {
        if (Data.ContainsKey(Id))
        {
            return Data[Id];
    
        }
        return null;
    }
     public List<Course> GetAll()
    {
        return Data.Values.ToList();
    }

    public void Update(Course course)
    {
        if (Data.ContainsKey(course.Id))
        {
            Data [course.Id]=course;
    
        }
    }
    public void DeletById(string Id)
    {
        Data.Remove(Id);
    }
}
