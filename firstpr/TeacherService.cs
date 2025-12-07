using System.Collections.Generic;
using firstpr;   

public class TeacherService
{
    private readonly ITeacherRepository _repository;

    public TeacherService(ITeacherRepository repository)
    {
        _repository = repository ?? new TeacherRepository();
    }

    public void Add(Teacher teacher)
    {
        if (string.IsNullOrEmpty(teacher.Id) || string.IsNullOrEmpty(teacher.Name))
            return;

        _repository.Add(teacher); 
    }

    public Teacher GetById(string Id)
    {
        return _repository.GetById(Id); 
    }

    public List<Teacher> GetAll()
    {
        return _repository.GetAll(); 
    }

    public void Update(Teacher teacher)
    {
        if (string.IsNullOrEmpty(teacher.Id) || string.IsNullOrEmpty(teacher.Name))
            return;

        _repository.Update(teacher); 
    }

    public void DeleteById(string Id)
    {
        if (string.IsNullOrEmpty(Id))
            return;

        _repository.Delete(Id); 
    }
}