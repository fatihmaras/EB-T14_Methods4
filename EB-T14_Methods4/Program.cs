using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodlarOrnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir Sayı Giriniz: ");
            int GirilenSayi = int.Parse(Console.ReadLine());

            TekmiCiftmi(GirilenSayi);
            Console.ReadLine();

        }

        static void TekmiCiftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir...");
            }
            else
            {
                Console.WriteLine("Sayı Tektir...");

            }

        }
    }
}

