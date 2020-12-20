using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class ChungCu : KhuDat
    {
        private int soTang;

        public int SoTang { get; set; }
        public ChungCu() { }
        public ChungCu(int tang)
        {
            SoTang = tang;
        }
        public ChungCu(string address, float gia, float dt, int tang) : base(address, gia, dt)
        {
            SoTang = tang;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Input Tang:");
            SoTang = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine(" So Tang:{0}", this.SoTang);
        }
    }
}
