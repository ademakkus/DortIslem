using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DortIslem
{ /// <summary>
  /// Adem AKKUŞ tarafından 31.10.2019 tarihinde
  /// ALTI İŞLEM YAPAN PROGRAM 
  /// </summary>
  ///
  /// 
  
  class Program
    {
     
        
        static void Main(string[] args)
        {
            WriteLine("*** ALTI İŞLEM YAPAN PROGRAM ****");
            int sonuc = 0;
            int birinciSayi, ikinciSayi;    ///değişkenlerin ilk kelimenin ilk harfi küçük
            int kullaniciSecimi = -1;     ///değişkenlerin diğer kelimelerin ilk harfi büyük
            while (kullaniciSecimi != 0)
            {
                ForegroundColor = ConsoleColor.DarkYellow;
                Write("\nBirinci sayıyı giriniz: ");
                birinciSayi = int.Parse(ReadLine());
                Write("İkinci sayıyı giriniz: ");
                ikinciSayi = int.Parse(ReadLine());
                kullaniciSecimi = MenuGoster();
                //Write("\nİşlem seçimi : {0}",kullaniciSecimi);
                //WriteLine("Seçim : {0}",kullaniciSecimi);

                switch (kullaniciSecimi)
                {
                    case 1: sonuc = ToplamaIslemi(birinciSayi, ikinciSayi); break;
                    case 2: sonuc = CikarmaIslemi(birinciSayi, ikinciSayi); break;
                    case 3: sonuc = CarpmaIslemi(birinciSayi, ikinciSayi); break;
                    case 4: sonuc = BolmeIslemi(birinciSayi, ikinciSayi); break;
                    case 5: sonuc = ModAlmaIslemi(birinciSayi, ikinciSayi); break;
                    case 6: sonuc = KuvvetAlmaIslemi(birinciSayi, ikinciSayi); break;
                }
                Console.WriteLine("\n İşlemin sonucu : " + sonuc);
                ForegroundColor = ConsoleColor.Red;
                Write("\n Çıkmak için 0 sıfıra, devam etmek diğer herhangi bir tuşa basın : ");
                kullaniciSecimi = int.Parse(ReadLine());
                /////
            }



            //ReadKey();
        }

        #region Altı İşlemin metodları
        private static int KuvvetAlmaIslemi(int birinciSayi, int ikinciSayi)
        {
            return (int)Math.Pow(birinciSayi, ikinciSayi);
        }

        private static int ModAlmaIslemi(int birinciSayi, int ikinciSayi)
        {
            return (birinciSayi % ikinciSayi);
        }

        private static int BolmeIslemi(int birinciSayi, int ikinciSayi)
        {
            return birinciSayi / ikinciSayi;
        }

        private static int CarpmaIslemi(int birinciSayi, int ikinciSayi)
        {
            return birinciSayi * ikinciSayi;
        }

        private static int CikarmaIslemi(int birinciSayi, int ikinciSayi)
        {
            return birinciSayi - ikinciSayi;
        }

        private static int ToplamaIslemi(int birinciSayi, int ikinciSayi)
        {
            return birinciSayi + ikinciSayi;
        }
        #endregion

        #region Menü Seçimi Metodu
        /// <summary>
        /// Klavyeden girilen değere göre menü seçimi yapan metod(yordam)
        /// </summary>
        /// <returns>int seçenek değeri döndürür.</returns>
        private static int MenuGoster()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("\n**** İŞLEM SEÇİNİZ *****\n" +
                      "1- Toplama İşlemi\n" +
                              "2- Çıkarma İşlemi\n" +
                              "3- Çarpma İşlemi\n" +
                              "4- Bölme İşlemi \n" +
                              "5 - Mod Alma İşlemi\n " +
                              "6- Kuvvet Alma İşlemi\n" +
                      " sayılarından birini yazınız . ");
            Write(" Seçim : ");
            int secim = int.Parse(ReadLine() ?? throw new InvalidOperationException());

            return secim;
        }
        #endregion
    }
}
