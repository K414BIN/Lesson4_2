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
// Программа суммирует введеные числа, однако я теряю один первый символ в строке
// Помогите я не смог разобраться...
            Console.WriteLine("Сумма введеных чисел равна " + sumAll(input));
            Console.ReadLine();
        }

        static int sumAll(string arr)
        {
            // строка для объединения и последующей конверсии символов в число
            string str = null;
            int i;
            // длина входящей строки - это массив символов минус единица
            i = arr.Length - 1;
            char[] a = new char[i];
            // конвертация в строки в символьный массив 
            a = arr.ToCharArray();
            //  в эту переменную положим сумму чисел
            int x = 0;
            for (int j =i;j!=0;j-- )
            {
                if (a[j] == ' ' )
                {
                    // еще раз конвертируем строку в массив
                    char[] b = str.ToCharArray();
                    b = str.ToCharArray();
                    // функция переворачивает значения в массиве
                    Array.Reverse(b);
                    string str1 = new string(b);
                    x = x + Convert.ToInt32(str1);
                    str =  null;
                   
                }
                else
                {
                    str =str +  a[j];
                }
            }
            return x;
        }
    }
}
