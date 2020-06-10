using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Bunglon : Hewan
    {
        public override void BertahanHidup()
        {
            Console.WriteLine("Bunglon bertahan hidup dengan cara Menipu musuh");
            Console.WriteLine("Dengan cara merubah warna tubuhnya sesuai warna sekitarnya");
        }
    }
}
