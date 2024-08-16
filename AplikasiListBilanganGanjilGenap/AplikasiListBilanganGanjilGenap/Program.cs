using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiListBilanganGanjilGenap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi List Bilangan Ganjil Genap");
            Console.WriteLine("\n========================================================================================================================");
            Console.WriteLine("Nama : Sahrul Ramadhan Hardiansyah");
            Console.WriteLine("Kelas : X - PPLG");
            Console.WriteLine("Absen : 31");
            Console.WriteLine("========================================================================================================================");


            //Bilangan Ganjil
            Console.WriteLine("\nList Bilangan Ganjil");

            for (int i = 1; i <= 1000; i++) //Melakukan loop dari 2 hingga 1000
            {
                if (i % 2 != 0) // Jika sisa bagi tidak sama dengan 0, berarti ganjil
                {
                    Console.WriteLine(i + " "); //Maka tampilkan bilangan ganjil ke console
                }
            }


            //Bilangan Genap
            Console.WriteLine("\nList Bilangan Genap :");

            for (int i = 1; i <= 1000; i++) //Melakukan loop dari 2 hingga 1000

                if (i % 2 == 0) // Jika sisa bagi sama dengan 0, berarti genap
                {
                    Console.WriteLine(i + " "); //Maka tampilkan bilangan genap ke console
                }
        }
    }

}
