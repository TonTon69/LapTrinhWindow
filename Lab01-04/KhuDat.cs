using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class KhuDat
    {
        protected string diaDiem;
        protected float giaBan;
        protected float dienTich;

        public string DiaDiem { get; set; }
        public float GiaBan { get; set; }
        public float DienTich { get; set; }

        public KhuDat() { }
        public KhuDat(string address, float gia, float dt)
        {
            DiaDiem = address;
            GiaBan = gia;
            DienTich = dt;
        }

        public virtual void Input()
        {
            Console.Write("Input Dia Diem:");
            DiaDiem = Console.ReadLine();
            Console.Write("Input Gia Ban:");
            GiaBan = float.Parse(Console.ReadLine());
            Console.Write("Input Dien Tich:");
            DienTich = float.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write("Dia Diem:{0} - Gia Ban:{1} VND - Dien Tich:{2} m2", this.DiaDiem, this.GiaBan, this.DienTich);
        }
    }
}
