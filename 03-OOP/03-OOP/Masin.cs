using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP
{
    internal  class Masin
    {
       public string masinMarka;
        public string masinModel;
        public string masinRengi;
        public int masinIl;
        private int masinVin;


        public Masin(string _masinMarka,string _masinModel,string _masinRengi,int _masinIl)
        {
            masinMarka = _masinMarka;
            masinModel = _masinModel;
            masinRengi = _masinRengi;
            masinIl = _masinIl;
        }


        public int  getVinKod()
        {
            return masinVin;

        }


        public void setVinKod( int vinKod)
        {

            if (vinKod < 100)
            {
                masinVin = 0;
            }
            else
            {
                masinVin = vinKod;

            }

        }





        public void masiniIseSal()
        {
            Console.WriteLine("muherrik ise dusdu");
        }

        public virtual void masiniSondur()
        {
            Console.WriteLine("muherrik sonduruldu");
        }

        public static void MethodHaqqindaInfo()
        {
            Console.WriteLine("men static olaraq teyin olunmusam");

        }


    }
}
