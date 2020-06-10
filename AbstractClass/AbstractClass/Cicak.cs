using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Cicak : Hewan
    {
        public override void BertahanHidup()
        {
            Console.WriteLine("Cicak bertahan hidup dengan cara Menipu musuh");
            Console.WriteLine("Dengan cara memutus ekornya");
        }
    }
}
