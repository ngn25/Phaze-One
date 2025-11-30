public class CourseService
{
    private readonly Dictionary<string, Course> data = new Dictionary<string, Course>();
    private readonly StudentService studentService;
    private readonly TeacherService teacherService;

    public CourseService(StudentService studentService, TeacherService teacherService)
    {
        this.studentService = studentService;
        this.teacherService = teacherService;
    }

    public bool Add(Course course)
    {
        // Check if course exists
        if (data.ContainsKey(course.Id))
            return false;

        // Validate teacher
        if (teacherService.GetById(course.TeacherId) == null)
            return false;

        // Validate students
        if (!ValidateStudents(course.StudentIds))
            return false;

        // Add course
        data.Add(course.Id, course);
        return true;
    }

    public Course GetById(string id)
    {
        data.TryGetValue(id, out Course course);
        return course;
    }

    public List<Course> GetAll()
    {
        return data.Values.ToList();
    }

    public bool Update(Course course)
    {
        // Must already exist
        if (!data.ContainsKey(course.Id))
            return false;

        // Validate teacher
        if (teacherService.GetById(course.TeacherId) == null)
            return false;

        // Validate students
        if (!ValidateStudents(course.StudentIds))
            return false;

        data[course.Id] = course;
        return true;
    }

    public bool DeleteById(string id)
    {
        return data.Remove(id);
    }

    private bool ValidateStudents(List<string> studentIds)
    {
        if (studentIds == null || studentIds.Count == 0)
            return true;

        foreach (var studentId in studentIds)
        {
            if (studentService.GetById(studentId) == null)
                return false;
        }

        return true;
    }
}