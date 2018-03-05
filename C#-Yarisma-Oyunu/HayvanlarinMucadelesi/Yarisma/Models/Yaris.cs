using System;
using Yarisma.Models;

namespace YarismaDunyasi.Models
{
    public class Yaris
    {
        public double UretilenSayi
        {
            get
            {
                return new Random().NextDouble() * 100;
            }
        }
        public void YarisiBaslat()
        {
            Cakal cakal = new Cakal();
            Fil fil = new Fil();
            DeveKusu deveKusu = new DeveKusu(); 
            int sayac=0;
            do
            {
                ++sayac;

                cakal.KonumDegistir();
                fil.KonumDegistir();
                deveKusu.KonumDegistir();

                Console.Write(sayac + ". tur     ");
                for (int i = 0; i < 70; i++)
                {
                    if (cakal.KonumX == i) Console.Write("Ç");
                    if (fil.KonumX == i) Console.Write("F");
                    if (deveKusu.KonumX == i) Console.Write("D");
                    Console.Write(" ");
                }

                Console.WriteLine();
            } while (cakal.KonumX <= 70 && fil.KonumX <=70 && deveKusu.KonumX<=70);
            Console.WriteLine($"Fil   {fil.KonumX}   Çakal   {cakal.KonumX}   Deve  {deveKusu.KonumX}");
        }

    }
}
