using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction menggunakan Interface
            Console.WriteLine("Nama\t: Trias Handayani");
            Console.WriteLine("NIM\t: 19.11.2733");
            Console.WriteLine("Kelas\t: 19-IF03");
            Console.WriteLine();

            IHewan hewan;
            hewan = new Bunglon();
            hewan.BertahanHidup();

            Console.WriteLine();
            hewan = new Cicak();
            hewan.BertahanHidup();

            Console.ReadKey();
        }
    }
}
