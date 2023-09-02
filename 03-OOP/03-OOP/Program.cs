using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //int a = 3;

            //Console.WriteLine(a);


            //a = 5;
            //Console.WriteLine(a);



            //Masin masin1 = new Masin();
            //masin1.masinMarka = "bmw";
            //masin1.masinModel = "e39";
            //masin1.masinRengi = "blue";
            //masin1.masinIl = 1997;
            //masin1.masinVin = 1233456;

            //Masin masin2 = new Masin();
            //masin1.masinMarka = "mercedes";
            //masin1.masinModel = "c klass";
            //masin1.masinRengi = "black";
            //masin1.masinIl = 1998;
            ////masin1.masinVin = 12334567;

            Masin masin1 = new Masin("bmw", "e39", "blue", 1997);
            Masin masin2 = new Masin("mercedes", "e39", "blue", 1997);

            Console.WriteLine(masin1.masinMarka);
            Console.WriteLine(masin2.masinMarka);



            //Console.WriteLine(masin1.masinMarka);
            ////Console.WriteLine(masin1.);

            //masin1.masiniIseSal();
            //masin1.masiniSondur();

            //masin1.setVinKod(101);


            //int vinKod=masin1.getVinKod();

            //Console.WriteLine(vinKod);


            //Console.WriteLine(masin2.masinMarka);


            //ElektroCar masin2 = new ElektroCar("tesla", "model 3", "gray", 2020);

            //Console.WriteLine(masin2.masinMarka);

            //masin2.masiniIseSal();
            //masin2.BatareyaFaizi();
            ////masin1.BatareyaFaizi();

            //Console.WriteLine("avtomobiller sonduruldu");

            ////masin1.masiniSondur();
            //masin2.masiniSondur();

            // numuneler burada

            //int[] arr = {1,2,3,4,5};
            //string[] arr = { "qurban", "sabir", "eli" };
            //int cem = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //Console.WriteLine(arr[i]);
            //    //cem = cem + arr[i];
            //    //Console.WriteLine(cem);

            //        if (arr[i].Length >= 5)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //Console.WriteLine(cem);
            //ElektroCar.MethodHaqqindaInfo();
            //Masin.MethodHaqqindaInfo();

        }
    }
}
