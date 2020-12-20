using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class Program
    {
        private static List<KhuDat> InputListKD()
        {
            List<KhuDat> listKhuDats = new List<KhuDat>();
            Console.Write("Input N=");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ----Input List KD----");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Input KD thu {0}", i + 1);
                KhuDat temp = new KhuDat();
                temp.Input();
                listKhuDats.Add(temp);
            }
            return listKhuDats;
        }
        private static void OutputListKD(List<KhuDat> listKhuDat)
        {
            foreach (KhuDat sv in listKhuDat)
            {
                sv.Output();
            }
        }
        public static void OutputListKDSort(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("---List KD co dien tich dc sap xep tang dan---");
            List<KhuDat> listKhuDatSort = listKhuDat.OrderBy(p => p.DienTich).ToList();
            OutputListKD(listKhuDatSort);
        }
        public static void OutputListKDGiavaDT(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("---List KD co gia ban < 1 ty va dien tich >= 60 m2---");
            List<KhuDat> listKhuDatGiavaDT = listKhuDat.Where(p => p.GiaBan < 1000000000 && p.DienTich >= 60).ToList();
            if (listKhuDatGiavaDT.Count() == 0)
                Console.WriteLine("Khong co KD nao co gia ban < 1 ty va dien tich >= 60 m2");
            else
                OutputListKD(listKhuDatGiavaDT);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<KhuDat> listKhuDat = InputListKD();
            Console.WriteLine("---List Khu Dat---");
            OutputListKD(listKhuDat);

            OutputListKDSort(listKhuDat);
            OutputListKDGiavaDT(listKhuDat);
            Console.ReadKey();
        }
    }
}
