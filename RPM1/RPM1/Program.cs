using System;

namespace RPM1
{
    class Program
    {
        static void Main(string[] args)
        {
            Drobi drob = new Drobi();
            drob.chisl = 5;
            drob.znam = 10;

            drob.chisl2 = 10;
            drob.znam2 = 5;

            drob.Deciat();
            drob.Calculations();
            drob.PlusOrMinus();
            drob.Index();
        }
    }

    class Drobi
    {
        public double chisl;
        public double znam;

        public double chisl2;
        public double znam2;

        //получать из дроби число в десятичном виде (1)
        public void Deciat()
        {
            Console.WriteLine("Задание 1");

            double c = chisl / znam;
            Console.WriteLine(c);
        }

        //выполнять между дробями основные математические операции (сложение, вычитание, умножение, деление) (2)
        public void Calculations()
        {
            Console.WriteLine("Задание 2");

            double plus = (chisl / znam) + (chisl2 / znam2);
            double minus = (chisl / znam) - (chisl2 / znam2);
            double multiplication = (chisl / znam) * (chisl2 / znam2);
            double division = (chisl / znam) / (chisl2 / znam2);
            Console.WriteLine(plus);
            Console.WriteLine(minus);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
        }

        //получить знак дроби (3)
        public void PlusOrMinus()
        {
            Console.WriteLine("Задание 3");

            double result = chisl / znam;
            if (Math.Sign(result) == 1)
            {
                Console.WriteLine("Знак дроби '+'");
            }
            else if (Math.Sign(result) == -1)
            {
                Console.WriteLine("Знак дроби '-'");
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }

        // 5
        public void Index()
        {
            Console.WriteLine("Задание 5");

            string NewStr = Convert.ToString(chisl) + "/" + Convert.ToString(znam);
            char[] Symbols = NewStr.ToCharArray();

            Console.WriteLine(Symbols[0]);
            Console.WriteLine(Symbols[Symbols.Length - 1]);
        }
    }
}