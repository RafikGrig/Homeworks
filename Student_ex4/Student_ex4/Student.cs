using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_ex4
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string,int> TestScore = new Dictionary<string, int>();

        public Student() { }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Add test result for a student
        /// </summary>
        /// <param name="course"></param>
        /// <param name="score"></param>
        public void AddTestResult(string course, int score)
        {
            this.TestScore.Add(course, score);
        }

        public override string ToString()
        {
            string testScores = string.Empty;
            foreach (var key in TestScore.Keys)
            {
                testScores += key + "-" + TestScore[key] + "\n";
            }

            return $"Student name:{Name}  ID:{Id} \n{testScores}";
        }
    }
}
