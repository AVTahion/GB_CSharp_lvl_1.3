using System;

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
    /// <summary>
    /// Класс дробей — рациональных чисел, являющихся отношением двух целых чисел
    /// </summary>
    class RationalNumber
    {
        int _nu; // numerator
        uint _de; // denominator

        public int Nu
        {
            get
            {
                return _nu;
            }
            set
            {
                _nu = value;
            }
        }

        public uint De
        {
            get
            {
                return _de;
            }
            set
            {
                if (value != 0)
                {
                    _de = value;
                }
                else
                {
                    Console.WriteLine("Знаменатель не может быть равен 0");
                }
            }
        }

        public double Decimal => (double)_nu / _de;

        public RationalNumber (int nu, uint de)
        {
            _nu = nu;
            _de = de;
        }

        /// <summary>
        /// Метод складывает дроби
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public RationalNumber Sum(RationalNumber x)
        {
            RationalNumber y = new RationalNumber(1, 1);
            y._nu = _nu * (int)x._de + x._nu * (int)_de;
            y._de = _de * x._de;
            return y;
        }

        /// <summary>
        /// Метод умножает дроби
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public RationalNumber Mult(RationalNumber x)
        {
            RationalNumber y = new RationalNumber(1, 1);
            y._nu = _nu * x._nu;
            y._de = _de * x._de;
            return y;
        }

        /// <summary>
        /// Метод вычетает дроби.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public RationalNumber Subtraction(RationalNumber x)
        {
            RationalNumber y = new RationalNumber(1, 1);
            y._nu = _nu * (int)x._de - x._nu * (int)_de;
            y._de = _de * x._de;
            return y;
        }

        /// <summary>
        /// Метод делит дроби.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public RationalNumber Division(RationalNumber x)
        {
            RationalNumber y = new RationalNumber(1, 1);
            y._nu = _nu * (int)x._de;
            if (x._nu > 0)
            {
                y._de = _de * (uint)x._nu;
            }
            else
            {
                y._nu = -y._nu;
                y._de = _de * (uint)x._nu;
            }
            return y;
        }

        /// <summary>
        /// Метод упрощения дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public void Reduction()
        {
            int y_nu = _nu;
            uint y_de = _de;
            uint NOD = 0;
            while (_nu != 0 & _de != 0)
            {
                if (_nu > _de)
                    _nu = _nu % (int)_de;
                else
                {
                    _de = _de % (uint)_nu;
                }
            }
            NOD = (uint)_nu + _de;
            _nu = y_nu / (int)NOD;
            _de = y_de / NOD;
        }

        /// <summary>
        /// Метод выводит в консоль дробь в формате "числитель/знаменатель"
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{ _nu}/{_de}");
        }
    }
}
