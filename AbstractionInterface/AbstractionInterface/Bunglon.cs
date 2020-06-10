using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class Bunglon : IHewan
    {
        public void BertahanHidup()
        {
            Console.WriteLine("Bunglon bertahan hidup dengan cara Menipu musuh");
            Console.WriteLine("Dengan cara merubah warna tubuhnya sesuai warna sekitarnya");
        }
    }
}
