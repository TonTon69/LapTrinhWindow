using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value;  }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Student()
        {

        }
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }

        public void Input()
        {
            Console.Write("Input MSSV:");
            StudentID = Console.ReadLine();
            Console.Write("Input FullName:");
            FullName = Console.ReadLine();
            Console.Write("Input AverageScore:");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Input Faculty:");
            Faculty = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("MSSV:{0} FullName:{1} AverageScore:{2} Faculty:{3}", this.StudentID, this.FullName, this.AverageScore, this.Faculty);
        }
    }
}
