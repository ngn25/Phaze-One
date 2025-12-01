class Program
{
    static void Main()
    {

        StudentService studentService = new StudentService();
        TeacherService teacherService = new TeacherService();
        CourseService courseService = new CourseService(tudentservice, teacherservice);// ساخت سرویس ها



        while (true)//حلقه ی بی پایان برای دستور کاربر
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                continue;
            }

            string[] parts = input.Split(' ');//شکستن ورودی به آرایه

            string target = parts[0];//student,teacher,course
            string action = parts[1];//add,remove,..

            if (target.Equals("student", StringComparison.OrdinalIgnoreCase) &&
            action.Equals("add", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length < 7)//بررسی تعداد بخش ها
                {
                    Console.WriteLine("not enough parametrs for student add!");
                    continue;
                }
                Student student = new Student
                {
                    Id = parts[2],
                    Name = parts[3],
                    DateOfBirth = parts[4],
                    Email = parts[5],
                    PhoneNumber = parts[6]
                    
                };
            

                studentService.Add(student);
                Console.WriteLine("student added.");


            }

        }
    }


}
