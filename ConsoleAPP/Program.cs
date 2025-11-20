using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Okuduğunuz Bölümü Giriniz:");
            string bolum = Console.ReadLine();
            Console.WriteLine($"{ad} {soyad} {bolum} bölümünde okuyor.");
            Console.WriteLine("Devam etmek için bir tuşa basınız.");
            Console.ReadLine();
        }
    }
}
