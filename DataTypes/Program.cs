using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integer
            int age = 24;
            Console.WriteLine(age);

            //check the Minimum Value and Max Value
            Console.WriteLine(int.MaxValue); //2147483647
            Console.WriteLine(int.MinValue); //-2147483648

            //long
            long bigNumber = 900000000L;

            //900000000 is an integer to make it a long number you need to put L in the end
            //900000000L
            //int32 for integer and int64 for long
            Console.WriteLine(bigNumber);



            Console.ReadLine();


        }
    }
}
