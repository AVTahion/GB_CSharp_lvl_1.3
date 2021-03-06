﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  3)  *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей.
        Написать программу, демонстрирующую все разработанные элементы класса.
        * Добавить свойства типа int для доступа к числителю и знаменателю;
        * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        *** Добавить упрощение дробей.

        Кушмилов Александр 
*/

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rationalNumber = new RationalNumber(20, 55);
            rationalNumber.Print();
            rationalNumber.Reduction();
            rationalNumber.Print();
            double i = rationalNumber.Decimal;
            Console.WriteLine(i);
            Console.ReadKey();

            rationalNumber.De = Convert.ToUInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
