using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student : Person
    {
        private float averageScore;
        private string faculty;
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
        public Student() { }
        public Student(string id, string name)
        {
            MaSo = id;
            HoTen = name;
        }
        public Student(string id, string name, float score, string faculty) : base(id, name)
        {
            AverageScore = score;
            Faculty = faculty;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Input AverageScore:");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Input Faculty:");
            Faculty = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine(" AverageScore:{0} Faculty:{1}", this.AverageScore, this.Faculty);
        }
    }
}
