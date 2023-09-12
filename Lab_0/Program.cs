using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    
    internal class Program
    {
        static int Multiplication(int FirstValue, int SecondValues)
        {
            return FirstValue * SecondValues;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int FirstValue = random.Next(100 - 50);
            int SecondValue = random.Next(100 - 50);
            Console.WriteLine($"Ваше первое число:{FirstValue} \nВаше второе число:{SecondValue} \nРезультат вычислений: {Multiplication(FirstValue,SecondValue)}");


            

            Console.ReadLine();

        }
        
       }



}


