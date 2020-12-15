using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public Teacher() { }
        public Teacher(string address)
        {
            DiaChi = address;
        }
        public Teacher(string id, string name, string address) : base(id, name)
        {
            DiaChi = address;
        }
        public void InputTeacher()
        {
            base.Input();
            Console.Write("Input Address:");
            DiaChi = Console.ReadLine();
        }
        public void OutputTeacher()
        {
            base.Show();
            Console.WriteLine(" Address:{0}", this.DiaChi);
        }
    }
}
