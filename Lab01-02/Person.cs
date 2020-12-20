using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        protected string maSo;
        protected string hoTen;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public Person()
        {

        }
        public Person(string id, string name)
        {
            MaSo = id;
            HoTen = name;
        }
        public virtual void Input()
        {
            Console.Write("Input MaSo:");
            MaSo = Console.ReadLine();
            Console.Write("Input HoTen:");
            HoTen = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write("MaSo:{0} HoTen:{1}", this.MaSo, this.HoTen);
        }
    }
}
