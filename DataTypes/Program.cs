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
           
            //Numeric Data Types
            int x = 10, 
                y = 20, 
                z = 30;

            //integer
            int age = 24;

            //int age = declaring a value
            //=24; = initializing a value
            age = 50; //assigning a value
            Console.WriteLine(age);

            //check the Minimum Value and Max Value
            Console.WriteLine(int.MaxValue); //2147483647
            Console.WriteLine(int.MinValue); //-2147483648

            //long
            long bigNumber = 900000000L;
            Console.WriteLine(long.MaxValue); 
            Console.WriteLine(long.MinValue);

            //900000000 is an integer to make it a long number you need to put L in the end
            //900000000L
            //int32 for integer and int64 for long
            Console.WriteLine(bigNumber);

            double negative = -55.4D; //to make it a double number you need to put D in the end
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue); // 1.79769313486232E+308
            Console.WriteLine(double.MinValue); //- 1.79769313486232E+308

            float precision = 5.000001F; //to make it a float number you need to put F in the end
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue); //3.402823E+38
            Console.WriteLine(float.MinValue); //-3.402823E+38

            decimal money = 14.99M; //to make it a decimal number you need to put M in the end
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue); //79228162514264337593543950335
            Console.WriteLine(decimal.MinValue); //- 79228162514264337593543950335


            //Text Based Data Types
            string name = "Clarence";
            char MiddleInitial = 'D';

            Console.Write("Your Name is ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine(MiddleInitial);

            Console.ReadLine();


        }
    }
}
