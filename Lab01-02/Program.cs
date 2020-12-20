using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        private static void InputListPerson()
        {
            List<Person> listPersons = new List<Person>();
            Console.Write("Input N Person=");
            int N = Convert.ToInt32(Console.ReadLine());
            int chon;
            for(int i=0; i<N; i++)
            {
                Console.WriteLine("\n ----Input 1: Input List Student - Input 2: Input List Teacher----");
                chon = Convert.ToInt32(Console.ReadLine());
                if(chon == 1)
                {
                    Console.WriteLine("\n ----Input List Student----");
                    Student st = new Student();
                    st.InputStudent();
                    listPersons.Add(st);
                }
                else if (chon == 2)
                {
                    Console.WriteLine("\n ----Input List Teacher----");
                    Teacher te = new Teacher();
                    te.InputTeacher();
                    listPersons.Add(te);
                }    
            }       
        }
        private static void OutputListPerson(List<Person> listPerson)
        {
            foreach(Person pe in listPerson){
                pe.Show();
            }
        }
        private static void OutputListStudent(List<Person> listPerson)
        {
            foreach(Student st in listPerson){
                st.Show();
            }
        }
        private static void OutputListTeacher(List<Person> listPerson)
        {
            foreach(Teacher te in listPerson){
                te.Show();
            }
        }
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            InputListPerson();
            Console.WriteLine("\n ----List Student----");
            OutputListPerson(listPerson);
            Console.ReadKey();
        }
    }
}


