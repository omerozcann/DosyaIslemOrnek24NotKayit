using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String secim = "";
            do
            {
                Console.Clear();
                Console.WriteLine("İşlem Seçiniz");
                Console.WriteLine("K - Not Kaydet");
                Console.WriteLine("L - Notları Listele");
                Console.WriteLine("S - Notlari Sil");
                Console.WriteLine("E - Çıkış");
                secim= Console.ReadLine();
                if (secim == "K")
                {
                    String dersadi, turu, notu;
                    Console.WriteLine("Ders Adı:");
                    dersadi = Console.ReadLine();
                    Console.WriteLine("Not Türü");
                    turu = Console.ReadLine();
                    Console.WriteLine("Notu");
                    notu = Console.ReadLine();
                    File.AppendAllText("kayitlar.txt", dersadi + "\n" + turu + "\n" + notu + "\n");
                    Console.WriteLine("Kayıt Tamamlandı");
                    Console.ReadLine();
                }
                else if (secim == "L")
                {
                    if (File.Exists("kayitlar.txt") == true)
                    {
                        String veriler;
                        veriler = File.ReadAllText("kayitlar.txt");
                        Console.WriteLine(veriler);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kayıt Bulunamadı");
                        Console.ReadLine();
                    }
                }
                else if (secim == "S")
                {
                    String s = "";
                    Console.WriteLine("Silmek istediğinize emin misiniz E/H?");
                    s = Console.ReadLine();
                    if (s == "E")
                    {
                        File.Delete("kayitlar.txt");
                        Console.WriteLine("Kayıtlar Silindi");
                        Console.ReadLine();
                    }
                }

            } while (secim != "E");
        }
    }
}
