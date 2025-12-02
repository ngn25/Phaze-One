using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StudentService studentService = new StudentService();
        TeacherService teacherService = new TeacherService();
        CourseService courseService = new CourseService(studentService, teacherService);

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            string[] parts = input.Split(' ');

            if (parts.Length < 2)
            {
                Console.WriteLine("Invalid command.");
                continue;
            }

            string target = parts[0];
            string action = parts[1];

            // ========================= STUDENT ADD ================================
            if (target.Equals("student", StringComparison.OrdinalIgnoreCase) &&
                action.Equals("add", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length < 7)
                {
                    Console.WriteLine("Not enough parameters for student add!");
                    continue;
                }

                // تاریخ باید DateOnly باشد
                if (!DateOnly.TryParse(parts[4], out DateOnly dob))
                {
                    Console.WriteLine("Invalid date format!");
                    continue;
                }

                Student student = new Student()
                {
                    Id = parts[2],
                    Name = parts[3],
                    DateOfBirth = dob,
                    Email = parts[5],
                    PhoneNumber = parts[6]
                };

                studentService.Add(student);
                Console.WriteLine("Student added.");
                continue;
            }

            // ========================= STUDENT GETALL ================================
            if (target.Equals("student", StringComparison.OrdinalIgnoreCase) &&
                action.Equals("getall", StringComparison.OrdinalIgnoreCase))
            {
                List<Student> allStudents = studentService.GetAll();

                if (allStudents.Count == 0)
                {
                    Console.WriteLine("No students found!");
                    continue;
                }

                foreach (var s in allStudents)
                {
                    Console.WriteLine($"{s.Id} - {s.Name} - {s.DateOfBirth} - {s.Email} - {s.PhoneNumber}");
                }

                continue;
            }

            // ========================= STUDENT REMOVE ================================
            if (target.Equals("student", StringComparison.OrdinalIgnoreCase) &&
                action.Equals("remove", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length < 3)
                {
                    Console.WriteLine("Not enough parameters for student remove!");
                    continue;
                }

                string id = parts[2];
                studentService.DeleteById(id);
                Console.WriteLine("Student removed.");
                continue;
            }

            // ========================= STUDENT UPDATE ================================
            if (target.Equals("student", StringComparison.OrdinalIgnoreCase) &&
                action.Equals("update", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length < 7)
                {
                    Console.WriteLine("Not enough parameters for student update!");
                    continue;
                }

                if (!DateOnly.TryParse(parts[4], out DateOnly dob))
                {
                    Console.WriteLine("Invalid date format!");
                    continue;
                }

                Student updatedStudent = new Student()
                {
                    Id = parts[2],
                    Name = parts[3],
                    DateOfBirth = dob,
                    Email = parts[5],
                    PhoneNumber = parts[6]
                };

                studentService.Update(updatedStudent);
                Console.WriteLine("Student updated.");
                continue;
            }
        }
    }
}
