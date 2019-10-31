using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  static  System.Console;

namespace DortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            int kullaniciSecimi = -1;
            while (kullaniciSecimi!=0)
            {
                kullaniciSecimi = MenuGoster();

            }
            Write(kullaniciSecimi);
            ReadKey();
        }

        private static int MenuGoster()
        {
            Console.WriteLine("1- Toplama İşlemi\n" +
                              "2- Çıkarma İşlemi\n" +
                              "3- Çarpma İşlemi\n" +
                              "4- Bölme İşlemi \n" +
                              "5 - Mod Alma İşlemi");
            int secim = int.Parse(ReadLine());
            return secim;
        }
    }
}
