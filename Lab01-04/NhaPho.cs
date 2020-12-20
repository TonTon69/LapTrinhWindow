using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class NhaPho : KhuDat
    {
        private int namXayDung;
        private int soTang;

        public int NamXayDung { get; set; }
        public int SoTang { get; set; }
        public NhaPho() { }
        public NhaPho(int nam, int tang)
        {
            NamXayDung = nam;
            SoTang = tang;
        }
        public NhaPho(string address, float gia, float dt, int nam, int tang) : base(address, gia, dt)
        {
            NamXayDung = nam;
            SoTang = tang;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Input Nam Xay Dung:");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.Write("Input Tang:");
            SoTang = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine(" Nam Xay Dung:{0} - So Tang:{1}", this.NamXayDung, this.SoTang);
        }
    }
}
