using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа через пробел в одну строку:");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Сумма введеных чисел равна " + sumAll(input));
            Console.ReadLine();
        }

        static int sumAll(string arr)
        {
            int i=0;
            string[] str = arr.Split(' ');
            // я как-то не научился пользоваться foreach
            foreach ( var word in str)
            {
                i = i + Convert.ToInt32(word);
            }
            return i;
        }
    }
}
