using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace IuliaTiaStoian_ClassStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            for (int i = 0; i < 5; ++i)
            {
                string? name;
                byte age;

                // read Age and Name from the console
                // create a Student object with the above data
                // repeat the steps above to create four more Student objects
                while (true)
                {
                    Console.WriteLine($"Input student {i + 1}'s name:");
                    name = Console.ReadLine();
                    if (validateName(name)) { break; } else { Console.WriteLine("Invalid input!!!\n"); }
                }

                while (true)
                {
                    Console.WriteLine($"Input student {i + 1}'s age:");
                    if (!byte.TryParse(Console.ReadLine(), out age)) { Console.WriteLine("Invalid input!!!\n"); }
                    else
                    {
                        try
                        {
                            Student student = new Student(name, age);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine($"The age must be in the range [{Student.MIN_AGE} - {Student.MAX_AGE}]!!!\n");
                            continue;
                        }
                        students[i] = new Student(name, age);
                        break;
                    }
                }


            }

            // write their Info property at the console.
            foreach (Student student in students)
            {
                Console.WriteLine(student.Info);
            }

            // read from the console a mark for some of the five students(not for all of them)
            for (int i = 0; i < 3; ++i)
            {
                while (true)
                {
                    Console.WriteLine($"Input a mark for student {students[i].name}: ");
                    if (!byte.TryParse(Console.ReadLine(), out byte mark) || (mark < 1 || mark > 10)) { Console.WriteLine("Invalid input!!! Mark must be in the range [1-10]\n"); }
                    else { students[i].Mark = mark; break; }
                }
            }

            // write at the console the average mark for all students (ignore the students with no mark)
            int avg = 0;
            int cnt = 0;
            foreach (Student student in students)
            {
                if (student.Mark != null) { avg += (byte)student.Mark; ++cnt; }
            }

            avg /= cnt;
            Console.WriteLine($"The average mark of the students is: {avg}");
        }

        static bool validateName(string input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z\s]+$")) { return true; }
            return false;
        }
    }
}