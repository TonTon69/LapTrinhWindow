using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        private static List<Person> InputListPerson()
        {
            List<Person> listPersons = new List<Person>();
            Console.Write("Input N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int chon;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n --- Input 1: Input Student || Input 2: Input Teacher---");
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("- Input Student");
                        Student st = new Student();
                        st.Input();
                        listPersons.Add(st);
                        break;

                    case 2:
                        Console.WriteLine("- Input Teacher");
                        Teacher te = new Teacher();
                        te.Input();
                        listPersons.Add(te);
                        break;
                    default:
                        break;
                }    
            }
            return listPersons;
        }
        private static void OutputListPerson(List<Person> listPersons)
        {
            foreach (Person temp in listPersons)
            {
                temp.Output();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Person> listPersons = InputListPerson();
            Console.WriteLine("\n---List Person---");
            OutputListPerson(listPersons);

            //Xuat danh sach cac sinh vien thuoc khoa CNTT neu co
            Console.WriteLine("\n---List Sinh vien thuoc khoa CNTT---");
            List<Person> listStudentCNTT = listPersons.Where(p => ((p is Student) && (p as Student).Faculty == "CNTT")).ToList();
            if (listStudentCNTT.Count() == 0)
                Console.WriteLine("Khong co");
            else
                OutputListPerson(listStudentCNTT);

            //Xuat danh sach sinh vien co dtb < 5 va thuoc khoa CNTT
            Console.WriteLine("\n---List Sinh vien co dtb < 5 va thuoc khoa CNTT---");
            List<Person> listStudentdtbCNTT = listPersons.Where(p => ((p is Student) && (p as Student).AverageScore < 5) && ((p is Student) && (p as Student).Faculty == "CNTT")).ToList();
            if (listStudentdtbCNTT.Count() == 0)
                Console.WriteLine("Khong co");
            else
                OutputListPerson(listStudentdtbCNTT);

            //Xuat danh sach giang vien co dia chi chua thong tin Quan 9 neu co
            Console.WriteLine("\n---List Teacher Quan 9---");
            List<Person> listTeacherQ9 = listPersons.Where(p => ((p is Teacher) && (p as Teacher).DiaChi == "Quan 9")).ToList();
            if (listTeacherQ9.Count() == 0)
                Console.WriteLine("Khong co");
            else
                OutputListPerson(listTeacherQ9);

            //Xuat thong tin giang vien co ma giang vien la CHN060286 neu co
            Console.WriteLine("\n---Thong tin Teacher co ma giang vien la CHN060286 ---");
            List<Person> listTeacherCHN = listPersons.Where(p => ((p is Teacher) && (p as Teacher).MaSo == "CHN060286")).ToList();
            if (listTeacherCHN.Count() == 0)
                Console.WriteLine("Khong co");
            else
                OutputListPerson(listTeacherCHN);

            //Xuat danh sach sinh vien co dtb max va thuoc khoa CNTT
            Console.WriteLine("\n---List sinh vien co dtb max va thuoc khoa CNTT ---");
            float dtbMax = listPersons.Max(p => ((p as Student).AverageScore));
            List<Person> listStudentDtbMaxCNTT = listPersons.Where(p => ((p is Student) && (p as Student).Faculty == "CNTT") && ((p is Student) && (p as Student).AverageScore == dtbMax)).ToList();
            if (listStudentDtbMaxCNTT.Count() == 0)
                Console.WriteLine("Khong co");
            else
                OutputListPerson(listStudentDtbMaxCNTT);

            Console.ReadKey();
        }
    }
}


