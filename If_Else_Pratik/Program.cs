using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0 ;
            Console.Write("Lütfen bir sayi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi == 10)
            {
                Console.WriteLine("Girilen sayi 10'dur.");
            }
            else if( sayi < 10)
            {
                Console.WriteLine("Girilen sayi 10'dan küçüktür.");
            }
            else if (sayi > 10)
            {
                Console.WriteLine("Girilen sayi 10'dan büyüktür.");
            }
            if(sayi % 2==0)
            {
                Console.WriteLine("Girilen sayi çifttir.");
            }
            else 
            {
                Console.WriteLine("Girilen sayi tektir.");
            }
            Console.ReadLine();
        }
    }
}
