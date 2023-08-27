using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayFunctionOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[5]; // {1,12,3,4,5 }
            int[] arr2 = { 1, 4, 8, 9 }; //{ }
            arr1[1] = 34;
            arr1[2] = 43;
            arr1[3] = 1;
            arr1[4] = 3;
            arr1[0] = 4;




            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2.Length );

            //for (int i = 0; i <arr2.Length; i++)
            //{

            //    Console.WriteLine(arr2[i]);
            //}

            //string soz = "azerbaycan";

            //Console.WriteLine(soz[0]);
            //for (int i = 0; i < soz.Length; i++)
            //{

            //    //Console.WriteLine(soz[i]);

            //    if (soz[i] =='a' )
            //    {
            //        Console.WriteLine("indeksi" + i);
            //    }



            //}

            //int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //{ }


            //for (int i = 0; i < arr3.Length; i++)
            //{

            //    if (arr3[i] % 2 == 0)
            //    {
            //        Console.WriteLine(arr3[i]);

            //    }

            //}

            string soz1 = "baki";
            string soz2 = "lankaran";
            string soz3 = "beylagan";

            //Console.WriteLine(soz1[0]); Console.WriteLine(soz2[0]); Console.WriteLine(soz3[0]);    
            //Console.WriteLine(soz1.Length);
            //Console.WriteLine(soz2.Length);
            //Console.WriteLine(soz3.Length);

            //void UzunluguTap(string x)
            //{
            //    Console.WriteLine("daxil edilen sozun uzunlugu"+ x.Length);
            //    Console.WriteLine("0 simvol-  " + x[0]);
            //}

            //UzunluguTap(soz1);
            //UzunluguTap(soz2);









            //void UzunluguTapVoid()
            //{
            //    Console.WriteLine("hello cs402");
            //    //return 4;
            //}


            //int  UzunluguTapStatic()
            //{
            //    //Console.WriteLine("hello cs402");
            //    return 2;
            //}

            //UzunluguTap();  




            //int eded = UzunluguTap();
            //Console.WriteLine(eded);


            //int cemiTap(int a, int b)
            //{
            //    return a + b;
            //}

            //void cemiTapVoid(int a, int b)
            //{
            //    int cem;
            //     cem=a + b;


            //    Console.WriteLine("void funksiya"+cem); 
            //}



            //cemiTapVoid(2, 3);

            //int res = cemiTap(3, 4);
            ////int res = cemiTapVoid(3, 4);

            //Console.WriteLine("res   " + res);


            //void calculator(int a, int b)
            //{
            //    Console.WriteLine("netice");
            //    //Console.WriteLine(a+b);
            //  int netice=  toplama(a, b);
            //    int neticeFerq = ferqEmeliyyati(a, b);
            //    Console.WriteLine("netice diger funksiyadan gelib--"+netice);
            //    Console.WriteLine("neticeFerq diger funksiyadan gelib--" + neticeFerq);

            //    Console.WriteLine(a * b );
            //    Console.WriteLine(a / b );
            //}

            //calculator(8, 4);

            //int toplama(int x, int y)
            //{
            //    int cem = x + y;
            //    //Console.WriteLine("toplama funksiyasindan gelen netice-" + cem);
            //    return cem;
            //}

            //int ferqEmeliyyati(int x, int y)
            //{
            //    int ferq = x - y;
            //    //Console.WriteLine("toplama funksiyasindan gelen netice-" + cem);
            //    return ferq;
            //}


            string emeliyyat=Console.ReadLine();
            char emelhar = Convert.ToChar(emeliyyat);
            int cem;
            int a = 5;
            int b = 3;
            switch (emelhar)
            {
                case '+':
                    cem = a + b;
                    Console.WriteLine(cem);

                    break;
                case '-':
                    cem = a - b;
                    Console.WriteLine(cem);

                    break;
                case '*':
                    cem = a * b;
                    Console.WriteLine(cem);

                    break;

            }

            //Console.WriteLine(cem);













        }

    }
}
