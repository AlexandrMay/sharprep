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
        /*    int a = 10, b = 2, c = 0;
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
            */

            //Циклы
            int counter = 0;
            /* Label:
             counter++;
             Console.WriteLine("Counter = {0}", counter);
             if (counter < 3) goto Label;
             Console.WriteLine("End");
             Console.ReadKey();  

             while (counter < 3)
             {
                 counter++;
                 Console.WriteLine("Counter {0}", counter);
             }
             Console.ReadKey(); 

            const int maxAttempt = 5;
            int attempt = 0;
            String color = "red";

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Попытка № {0}", attempt);

                String value = Console.ReadLine();
                if (value == "exit")
                {
                    break;
                }
                if (value != color)
                {
                    continue;
                }
                Console.WriteLine("Угадали с {0} попытки", attempt);
                break;
            } */

            do
            {
                counter++;
                Console.WriteLine("Counter is {0}", counter);
            }
            while (counter < 3);
            Console.WriteLine("Произведено {0} итераций", counter);
            Console.ReadKey();








        }
    }
}
