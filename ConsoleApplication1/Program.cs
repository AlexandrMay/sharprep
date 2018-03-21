using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

     {
            int a = 10, b = 2, c = 0;
            if (a<b)
            {
                Console.WriteLine("a<b");
            }

            c = (a > b) ? a : b;
            Console.WriteLine(c);


            byte operand1 = 0, operand2 = 0;
            int result;

            operand1 = 0xFF;
            operand2 = 0x01;
            result = operand1 & operand2;
            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);

            byte aa = 0x71;
            aa = (byte)(aa << 2);
            Console.WriteLine(aa);
            aa = (byte)(aa >> 1);
            Console.WriteLine(aa);



            Console.ReadKey();


        }
    }
}
