using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_ex4
{
    public class StudentCatalog
    {
        public List<Student> Students = new List<Student>();

        /// <summary>
        /// Add a single student to the catalog. 
        /// </summary>
        /// <param name="aStudent"></param>        
        public void AddStudent(Student aStudent)
        {
            this.Students.Add(aStudent);
        }

        /// <summary>
        /// Given an id, return the student with that id. 
        /// If no student exists with the given id, return null. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student GetStudent(int id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if(Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetAverageForStudent(int id)
        {
            int average = -1;
            for (int i = 0; i < Students.Count; i++)
            {
                if(Students[i].Id == id && Students[i].TestScore.Count != 0)
                {
                    average = 0;
                    foreach (var score in Students[i].TestScore.Values)
                    {
                        average += score;
                    }
                    average /= Students[i].TestScore.Values.Count;
                    break;
                }
            }
            return average;
        }

        /// <summary>
        ///  Returns the total test score average for ALL students in the catalog. 
        /// </summary>
        /// <returns></returns>
        public int GetTotalAverage()
        {
            int totalAverage = 0;
            int countStudentWithoutScores = 0;
            for (int i = 0; i < Students.Count; i++)
            {
                if(GetAverageForStudent(Students[i].Id) == -1)
                {
                    countStudentWithoutScores++;
                    continue;
                }
                totalAverage += GetAverageForStudent(Students[i].Id);
            }
            if (Students.Count != 0)
            {
                totalAverage /= (Students.Count-countStudentWithoutScores);
                return totalAverage;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        ///  Get top three students who have the highest average score. 
        ///  If no student returns empty list. 
        /// </summary>
        /// <returns></returns>
        public List<Student> GetTopThreeStudents()
        {
            List<Student> ThreeBestStudents = new List<Student>();
            if (Students.Count < 4)
            {
                return ThreeBestStudents;
            }

            // create template min average student for inicialization 
            Student temp = new Student();
            temp.AddTestResult("no course", -1);
            Students.Add(temp);

            Student student1 = Students[Students.Count - 1];
            Student student2 = Students[Students.Count - 1];
            Student student3 = Students[Students.Count - 1];

            for (int i = Students.Count - 1; i >=0; i--)
            {
                if(GetAverageForStudent(Students[i].Id) > GetAverageForStudent(student1.Id))
                {
                    student3 = student2;
                    student2 = student1;
                    student1 = Students[i];
                }
                else
                {
                    if(GetAverageForStudent(Students[i].Id) > GetAverageForStudent(student2.Id))
                    {
                        student3 = student2;
                        student2 = Students[i];
                    }
                    else
                    {
                        if (GetAverageForStudent(Students[i].Id) > GetAverageForStudent(student3.Id))
                        {
                            student3 = Students[i];
                        }
                    }
                }
            }

            ThreeBestStudents.Add(student1);
            ThreeBestStudents.Add(student2);
            ThreeBestStudents.Add(student3);
            Students.Remove(temp);

            return ThreeBestStudents;

        }

    }
}
