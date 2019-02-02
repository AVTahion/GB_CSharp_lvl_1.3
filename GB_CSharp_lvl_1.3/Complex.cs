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
    struct Complex
    {
        public double im;
        public double re;

        public Complex (double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        /// <summary>
        /// Метод складывает комплексные числа.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Метод умножения комплексных чисел.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary>
        /// Метод вычитания комплексных чисел.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Subtraction(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
