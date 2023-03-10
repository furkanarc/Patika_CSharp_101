using System;

namespace Degiskenler_ve_Veri_Tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;                           // 1 byte (0 <-> 255)
            sbyte sb = -128;                        // 1 byte (-128 <-> 127)

            short s = -32768;                       // 2 byte (-32768 <-> 32767)
            ushort us = 65535;                      // 2 byte (0 <-> 65535)

            Int16 i16 = -32768;                     // 2 byte (-32768 <-> 32767)
            int i = -2147483648;                    // 4 byte (-2147483648 <-> 2147483647)
            Int32 i32 = -2147483648;                // 4 byte (-2147483648 <-> 2147483647)
            Int64 i64 = -9223372036854775808;       // 8 byte (-9223372036854775808 <-> 9223372036854775807)

            uint ui = 4294967295;                   // 4 byte (0 <-> 4294967295)
            long l = -9223372036854775808;          // 8 byte (-9223372036854775808 <-> 9223372036854775807)
            ulong ul = 18446744073709551615;        // 8 byte (0 <-> 18446744073709551615)

            float f =  3.4028235E+38f;                      // 4 byte (-3.4028235E+38f <-> 3.4028235E+38f)
            double d = 1.7976931348623157E+308;             // 8 byte (-1.7976931348623157E+308f <-> 1.7976931348623157E+308f)
            decimal de = 79228162514264337593543950335M;    // 16 byte (-79228162514264337593543950335 <-> 79228162514264337593543950335)

            char ch = 'a';                          // 2 byte 
            string str = "İsim";                    // Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;             // 10.03.2023 19:53:35

            object o1 = "x";
            object o2 = 4;
            object o3= 4.3;

            string str1 = "Mavi";
            string str2 = "Beyaz";
            string str3 = str1 + " " + str2;

            int i1 = 1;
            int i2 = 2;
            int i3 = i1 + i2;

            bool bool1 = 10 > 2;

            string str20 = "20";
            int int20 = 20;

            string sonuc1 = str20 + int20.ToString();
            Console.WriteLine(sonuc1);                      // Çıktı : 2020
            int sonuc2 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(sonuc2);                      // Çıktı :  40
            int sonuc3 = int20 + int.Parse(str20);
            Console.WriteLine(sonuc3);                      // Çıktı : 40

            

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);                  // Çıktı :  10.03.2023

            string datetime2 = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(datetime2);                  // Çıktı :  10.03.2023 

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);                  // Çıktı :  20:11
        }
    }
}
