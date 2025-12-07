using System.Collections.Generic;
using firstpr;   
public class StudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository ?? new StudentRepository();
    }

    public void Add(Student student)
    {
        if (string.IsNullOrEmpty(student.Id) || string.IsNullOrEmpty(student.Name))
            return;

        _repository.Add(student); 
    }

    public Student GetById(string Id)
    {
        return _repository.GetById(Id); 
    }

    public List<Student> GetAll()
    {
        return _repository.GetAll(); 
    }

    public void Update(Student student)
    {
        if (string.IsNullOrEmpty(student.Id) || string.IsNullOrEmpty(student.Name))
            return;

        _repository.Update(student);  
    }

    public void DeleteById(string Id)
    {
        if (string.IsNullOrEmpty(Id))
            return;

        _repository.Delete(Id); 
    }
}


































