using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstValue = 0;
            int SecondValue = 0;
            int result;
            while (true)
            {
                try
                {
                    Console.Write("ыВведите первое число для умножения ");
                    FirstValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число для умножения ");
                    SecondValue = Convert.ToInt32(Console.ReadLine());
                    result = FirstValue * SecondValue;
                    Console.WriteLine(result);
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некоректное значение, пожалуйста повторите попытку");

                }
            }

            Console.ReadLine();

        }
    }
}
