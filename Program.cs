using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukemmel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

           for(int i = 1; i<sayi; i++)
            {
                if(sayi % i == 0)
                {
                    toplam = toplam + i;
                }

                else
                {
                    i++;
                }
            }

           if(toplam == sayi)
            {
                Console.WriteLine(sayi + " sayısı Mükemmel Sayıdır");
            }

            else
            {
                Console.WriteLine(sayi + " sayısı Mükemmel Sayı Değildir");
            }

            Console.ReadLine();
           
        }
    }
}
