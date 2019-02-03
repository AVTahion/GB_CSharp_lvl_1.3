using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2)  а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.
        Сами числа и сумму вывести на экран, используя tryParse.
    3)  *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей.
        Написать программу, демонстрирующую все разработанные элементы класса.
        * Добавить свойства типа int для доступа к числителю и знаменателю;
        * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        *** Добавить упрощение дробей.

        Кушмилов Александр 
*/

namespace Task_2
{
    class Program
    {
        /// <summary>
        /// Метод проверяет является ли число положительным нечетным.
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        static bool OddPositiveCheck(int X)
        {
            return (X % 2 != 0 && X > 0) ? true : false;
        }

        /// <summary>
        /// Метод проверяет корректность введеных даных(число) и приводит к int32
        /// </summary>
        /// <returns></returns>
        static int EnterNumb()
        {
            int t = 0;
            bool cor;

            do
            {
                Console.WriteLine("Введите число:");
                cor = Int32.TryParse(Console.ReadLine(), out t);

            } while (!cor);

            return t;
        }

        static void Main()
        {
            int sum = 0;
            int n;
            string oddPosNum = "";
            do
            {
                n = EnterNumb();
                if (OddPositiveCheck(n))
                {
                    sum += n;
                    oddPosNum = oddPosNum + n + " "; 
                }
            }
            while (n != 0);
            Console.WriteLine($"Сумма введенных положительных нечетных чисел:{oddPosNum}= {sum}");
            Console.ReadKey();
        }
    }
}
