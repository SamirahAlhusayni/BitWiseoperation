using System;

namespace bitwiseOperation
{
    class Program
    {
        static bool isOdd(uint value)
        {
            return (value & 1) == 1;
        }
        static uint unpack(uint value)
        {
            return value & 255;
        }

        static string toBinary(uint value)
        {
            String result = "";

            for (int i = 32; i > 0; i--)
            {


                if (value > 0)
                {

                    result = (value & (1)) + result;
                    value = value >> 1;
                }
                else
                {
                    result = "0" + result;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(toBinary(31));

            //pack
            uint value = 0;
            byte one = 1;
            byte two = 8;
            byte three = 201;
            byte four = 25;

            value = (value | four);
            value = (value << 8);
            value = (value | three);
            value = (value << 8);
            value = (value | two);
            value = (value << 8);
            value = (value | one);
            Console.WriteLine(toBinary(value));


            //unpack
            Console.WriteLine(unpack(value));
            value >>= 8;
            Console.WriteLine(unpack(value));
            value >>= 8;
            Console.WriteLine(unpack(value));
            value >>= 8;
            Console.WriteLine(unpack(value));

            //is odd
            Console.WriteLine(isOdd(28));


        }
    }
}
