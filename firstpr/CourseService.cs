using System;
using System.Collections.Generic;
using System.Linq;

namespace firstpr
{
    public class CourseService
    {
        private readonly ICourseRepository _repository;
        private readonly StudentService _studentService;
        private readonly TeacherService _teacherService;

        public CourseService(StudentService studentService, TeacherService teacherService, ICourseRepository repository)
        {
            _studentService = studentService;
            _teacherService = teacherService;
            _repository = repository;
        }

        public void Add(Course course)
        {
            if (_repository.GetById(course.Id) != null)
            {
                Console.WriteLine($"Error: Course with id '{course.Id}' already exists!");
                return;
            }

            var teacher = _teacherService.GetById(course.TeacherId);
            if (teacher == null)
            {
                Console.WriteLine($"Error: Teacher with id '{course.TeacherId}' not found!");
                return;
            }

            var missingStudents = course.StudentIds
                .Where(sid => _studentService.GetById(sid) == null)
                .ToList();

            if (missingStudents.Any())
            {
                Console.WriteLine($"Error: The following students not found: {string.Join(", ", missingStudents)}");
                return;
            }

            _repository.Add(course);
            Console.WriteLine("Course added successfully.");
        }

        public void Update(Course course)
        {
            if (_repository.GetById(course.Id) == null)
            {
                Console.WriteLine($"Error: Course with id '{course.Id}' not found!");
                return;
            }

            var teacher = _teacherService.GetById(course.TeacherId);
            if (teacher == null)
            {
                Console.WriteLine($"Error: Teacher with id '{course.TeacherId}' not found!");
                return;
            }

            var missingStudents = course.StudentIds
                .Where(sid => _studentService.GetById(sid) == null)
                .ToList();

            if (missingStudents.Any())
            {
                Console.WriteLine($"Error: The following students not found: {string.Join(", ", missingStudents)}");
                return;
            }

            _repository.Update(course);
            Console.WriteLine("Course updated successfully.");
        }

        public Course? GetById(string id)
        {
            return _repository.GetById(id);
        }

        public List<Course> GetAll()
        {
            return _repository.GetAll();
        }

        public void DeleteById(string id)
        {
            if (_repository.GetById(id) == null)
            {
                Console.WriteLine($"Course with id '{id}' not found!");
                return;
            }

            _repository.Delete(id);
            Console.WriteLine("Course removed successfully.");
        }

        public ICourseRepository GetRepository() => _repository;
    }
}