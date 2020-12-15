using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        private static List<Student> InputListSV()
        {
            List<Student> listStudents = new List<Student>();
            Console.Write("Input N SV=");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ----Input List SV----");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Input SV thu {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                listStudents.Add(temp);
            }
            return listStudents;
        }
        private static void OutputListSV(List<Student> listStudent)
        {
            foreach (Student sv in listStudent)
            {
                sv.Show();
            }
        }
        public static void OutputListSVCNTT(List<Student> listStudent)
        {
            List<Student> listStudentCNTT = listStudent.Where(p => p.Faculty == "CNTT").ToList();
            if (listStudentCNTT.Count() == 0)
                Console.WriteLine("Ko co SV thuoc khoa CNNT");
            else
                OutputListSV(listStudentCNTT);
        }
        public static void OutputListSVDTB5(List<Student> listStudent)
        {
            List<Student> listStudentDTB5 = listStudent.Where(p => p.AverageScore >= 5).ToList();
            if(listStudentDTB5.Count() == 0)
                Console.WriteLine("Ko co SV thuoc co dtb >= 5");
            else
                OutputListSV(listStudentDTB5);
        }
        public static void OutputListSVSortDTB(List<Student> listStudent)
        {
            List<Student> listStudentSort = listStudent.OrderBy(p => p.AverageScore).ToList();
            OutputListSV(listStudentSort);
        }
        public static void OutputListSV_DTB_CNTT(List<Student> listStudent)
        {
            List<Student> listStudentDTB5_CNTT = listStudent.Where(p => p.AverageScore >= 5 && p.Faculty == "CNTT").ToList();
            if (listStudentDTB5_CNTT.Count() == 0)
                Console.WriteLine("Ko co SV co DTB >= 5 va thuoc khoa CNTT");
            else
                OutputListSV(listStudentDTB5_CNTT);
        }
        public static void OutputListSV_DTBMax_CNTT(List<Student> listStudent)
        {
            float stmax = listStudent.Max(p => p.AverageScore);
            List<Student> listStudentDTBMax_CNTT = listStudent.Where(p => p.AverageScore == stmax && p.Faculty == "CNTT").ToList();
            if (listStudentDTBMax_CNTT.Count() == 0)
                Console.WriteLine("Ko co SV co DTB max va thuoc khoa CNTT");
            else
                OutputListSV(listStudentDTBMax_CNTT);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Student> listStudent = InputListSV();
            Console.WriteLine("\n ----Output List SV----");
            OutputListSV(listStudent);
            Console.WriteLine("\n ----Output List SV CNTT----");
            OutputListSVCNTT(listStudent);
            Console.WriteLine("\n ----Output List SV DTB >=5 ----");
            OutputListSVDTB5(listStudent);
            Console.WriteLine("\n ----Output List SV tang dan DTB ----");
            OutputListSVSortDTB(listStudent);
            Console.WriteLine("\n ----Output List SV DTB >=5 & thuoc CNTT ----");
            OutputListSV_DTB_CNTT(listStudent);
            Console.WriteLine("\n ----Output List SV DTB Max & thuoc CNTT ----");
            OutputListSV_DTBMax_CNTT(listStudent);
            Console.ReadKey();
        }
    }
}
