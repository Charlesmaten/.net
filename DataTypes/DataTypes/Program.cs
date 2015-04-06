using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hej");
            Console.Write("Hej");
            Console.Write("Charlie" + System.Environment.NewLine);
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.ReadKey();
             * */

            int i = 10;
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(UInt32.MaxValue);
            Console.WriteLine(UInt32.MinValue);
            Console.WriteLine(UInt64.MaxValue);
            Console.WriteLine(UInt64.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Boolean b = new Boolean();
            bool b1 = true;
            bool b2 = false;
            Boolean b3 = new Boolean();

            byte b4 = 20;
            byte b5 = 250;
            byte b6 = 0;
            byte b7 = 255;

            char c = 'P';
            byte b8 = 80;
            Console.WriteLine(Convert.ToChar(b8));
            Console.WriteLine(c);

            byte b9 = 8;
            sbyte b19 = -128;
            sbyte b20 = 127;
            Console.WriteLine(b9);

            short s = 32767;
            short s2 = -32768;

            short s3 = 15;
            ushort s4 = 65535;
            ushort s5 = 0;

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            int testint = 40;
            Console.WriteLine("Size of integer: " + sizeof(char));
            Console.WriteLine("Size of long: " + sizeof(long));

            string teststring = "hej";
            char[] testchar = { 'h', 'e', 'j', '\0' };
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.ReadKey();


        }
    }
}
