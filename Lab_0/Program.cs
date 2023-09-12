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
            Random random = new Random();
            int FirstValue = random.Next(1000);
            int SecondValue = random.Next(1000);
            int result;
            result = FirstValue * SecondValue;
            Console.WriteLine($"\n Ваше первое число:{FirstValue} \nВаше второе число:{SecondValue} \nРезультат вычислений: {result}");


            




            Console.ReadLine();

        }
        
       }



}


