using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCatalog students = new StudentCatalog();

            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");
            Student diana = new Student(295, "Diana");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            students.AddStudent(anna);
            students.AddStudent(betty);
            students.AddStudent(carl);
            students.AddStudent(diana);            
            
            Console.WriteLine(anna);
            Console.WriteLine("Average for student with id=12 :" + students.GetAverageForStudent(12) + "\n");
            Console.WriteLine("Get student with id=92\n" + students.GetStudent(92) + "\n");
            Console.WriteLine("Total average of all students is: " + students.GetTotalAverage() + "\n");
            Console.WriteLine("Three Best Students are\n");

            List<Student> Best = students.GetTopThreeStudents();
            Console.WriteLine(Best[0] + "\nAverage=" + students.GetAverageForStudent(Best[0].Id));
            Console.WriteLine("---------------------------------");
            Console.WriteLine(Best[1] + "\nAverage=" + students.GetAverageForStudent(Best[1].Id));
            Console.WriteLine("---------------------------------");
            Console.WriteLine(Best[2] + "\nAverage=" + students.GetAverageForStudent(Best[2].Id));
            Console.WriteLine("---------------------------------");
        }
    }
}
