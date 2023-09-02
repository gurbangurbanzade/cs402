using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP
{
    internal class ElektroCar : Masin
    {
       
        public ElektroCar(string _masinMarka, string _masinModel, string _masinRengi, int _masinIl) : base(_masinMarka, _masinModel, _masinRengi, _masinIl)
        {
        }

        public void BatareyaFaizi()
        {
            Console.WriteLine("batareya 100%");
        }

        public override void masiniSondur()
        {
            Console.WriteLine("men elektrik muherrikiyem sonmurem");
        }

    }
}
