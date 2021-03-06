﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1)   а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        в) Добавить диалог с использованием switch демонстрирующий работу класса.
    2)  а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.
        Сами числа и сумму вывести на экран, используя tryParse.
    3)  *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей.
        Написать программу, демонстрирующую все разработанные элементы класса.
        * Добавить свойства типа int для доступа к числителю и знаменателю;
        * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        *** Добавить упрощение дробей.

        Кушмилов Александр 
*/


namespace GB_CSharp_lvl_1._3
{

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = new Complex(0,0);

            Console.WriteLine($"Выберите действие над комплексными числами 1+1i и 2+2i: 1 - для сложения, 2 - для умножения, 3 - для вычитания");
            int i = Convert.ToByte(Console.ReadLine());
            switch (i)
            {
                case 1: result = complex1.Plus(complex2);
                    break;
                case 2: result = complex1.Multi(complex2);
                    break;
                case 3: result = complex1.Subtraction(complex2);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }

    }
}
