using System;

namespace tip_donsumleri
{
    class Program
    {
        public static void Main(string[] args)
        {

            // İmplicit Conversion(Bilinçsiz Dönüşüm)
            byte a = 15;
            sbyte b = 20;
            short c = 10;

            int d = a + b + c;

            Console.WriteLine("d:" + d);

            long h =d;

            Console.WriteLine(h);

            float i = h;

            Console.WriteLine(i);

            string e = "halil";

            char f = 'a';

            object o = e+f+d;

            Console.WriteLine(o);

            // Explicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;

            Console.WriteLine("y :" + y);

            int z = 100;
            byte t = (byte)z;

            Console.WriteLine("t :" + t);

            float w = 10.3f;
            byte v = (byte)w;

            Console.WriteLine("v :" + v);


            // ToString Methodu


            int xx = 6;

            string yy = xx.ToString();

            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();

            Console.WriteLine("zz : " + zz);

            //system Convert

            string s1 = "10", s2="20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("toplam" + toplam);


            // parse

            ParseMethod();

            
        }

        public static void ParseMethod(){

            string metin1 = "10";
            string metin2 = "10,25";

            int rakam;
            double double1;

            rakam = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam:" + rakam);
            Console.WriteLine("double:" + double1);

                
            }
    }
}