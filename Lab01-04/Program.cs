using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Program
    {
        private static List<KhuDat> InputListKD()
        {
            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.Write("Input N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int chon;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n --- Input 1: Input Khu Dat || Input 2: Input Nha Pho || Input 3: Input Chung Cu---");
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("- Input Khu Dat");
                        KhuDat kd = new KhuDat();
                        kd.Input();
                        listKhuDat.Add(kd);
                        break;

                    case 2:
                        Console.WriteLine("- Input Nha Pho");
                        NhaPho nh = new NhaPho();
                        nh.Input();
                        listKhuDat.Add(nh);
                        break;
                    case 3:
                        Console.WriteLine("- Input Chung Cu");
                        ChungCu ch = new ChungCu();
                        ch.Input();
                        listKhuDat.Add(ch);
                        break;
                    default:
                        break;
                }
            }
            return listKhuDat;
        }
        private static void OutputListKD(List<KhuDat> listKhuDat)
        {
            foreach (KhuDat temp in listKhuDat)
            {
                temp.Output();
            }
        }
        static void Main(string[] args)
        {
            List<KhuDat> listKhuDat = InputListKD();

            Console.WriteLine("---List Khu Dat---");
            OutputListKD(listKhuDat);

            //Xuat tong gia ban cho 3 loai cua cty
            float giaKhuDat = 0;
            float giaNhaPho = 0;
            float giaChungCu = 0;
            foreach (var item in listKhuDat)
            {
                if (item.GetType() == typeof(KhuDat))
                {
                    giaKhuDat += item.GiaBan; 
                }
                if (item.GetType() == typeof(NhaPho))
                {
                    giaNhaPho += item.GiaBan;
                }
                if (item.GetType() == typeof(ChungCu))
                {
                    giaChungCu += item.GiaBan;
                }
            }
            Console.WriteLine("Tong gia Khu Dat: {0}, Gia Nha Pho: {1}, Gia Chung Cu: {2}", giaKhuDat, giaNhaPho, giaChungCu);

            //Xuat ds cac khu dat co dien tich > 100 m2 hoac la nha pho co dt > 60m2 va nam xay dung >= 2020 neu co.
            List<KhuDat> listKD = listKhuDat.Where(c => ((c is KhuDat) && (c as KhuDat).DienTich >= 100) ||
            ((c is NhaPho) && (c as NhaPho).DienTich >= 60 && (c as NhaPho).NamXayDung >= 2020)).ToList();
            if (listKD.Count() == 0)
                Console.WriteLine("Khong co");
            else
                OutputListKD(listKD);

            //Nhap vao cac thong tin can tim kiem (dia diem, gia, dien tich)
            Console.WriteLine("Nhap dia diem can tim:");
            string diaDiemCanTim = Console.ReadLine();
            Console.WriteLine("Nhap Gia can tim:");
            float giaCanTim = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Dien Tich can tim:");
            float dienTichCanTim = float.Parse(Console.ReadLine());
            List<KhuDat> listSearch = listKD.Where(c => c.DiaDiem.ToLower().Contains(diaDiemCanTim.ToLower()) &&
            c.GiaBan <= giaCanTim && c.DienTich >= dienTichCanTim).ToList();
            Console.WriteLine("---Thong tin list tat ca cac nha pho hoac chung cu phu hop yeu cau---");
            OutputListKD(listSearch);
            
            Console.ReadLine();
        }
    }
}
