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
                if (chon == 2)
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
        static void Main(string[] args)
        {
            /*Person p1 = new Person();
            Teacher t1 = new Teacher();
            Student s1 = new Student();

            Console.WriteLine("\n ----Input Teacher----");
            t1.InputTeacher();
            Console.WriteLine("\n ----List Teacher----");
            t1.OutputTeacher();

            Console.WriteLine("\n ----Input Student----");
            s1.InputStudent();
            Console.WriteLine("\n ----List Student----");
            s1.OutputStudent();*/

            List<Person> listPerson = new List<Person>();
            InputListPerson();
            Console.WriteLine("\n ----List Person----");
            OutputListPerson(listPerson);
            Console.ReadKey();
        }
    }
}
