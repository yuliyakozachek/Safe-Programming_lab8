using System;

namespace Yuliya
{
    delegate int Operation (int i, int j);
    delegate void GetGreeting();

    class Program
    {
        static void GoodMorning()
        {
            Console.WriteLine("Доброе утро!");
        }
        static void GoodDay()
        {
            Console.WriteLine("Добрый день!");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер!");
        }
        static void GoodNight()
        {
            Console.WriteLine("Доброй ночи!");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int IntegerDevide(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            GetGreeting del;
            if(DateTime.Now.Hour<12)
            {
                del=GoodMorning;
            }
            else if(DateTime.Now.Hour>=12 && DateTime.Now.Hour <17)
            {
                del=GoodDay;
            }
            else if(DateTime.Now.Hour>=17 && DateTime.Now.Hour <21)
            {
                del=GoodEvening;
            }
            else
            {
                del=GoodNight;
            }
            del();
            Operation delOper;
            Console.WriteLine("Введите два числа");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие (+,-,*,/)");
            Console.Write(">> ");
            char oper = Convert.ToChar(Console.ReadLine());
            if(oper=='+')
            {
                delOper=Add;
            }
            else if(oper=='-')
            {
                delOper=Subtract;
            }
            else if(oper=='*')
            {
                delOper=Multiply;
            }
            else if(oper=='/')
            {
                delOper=IntegerDevide;
            }
            else
            {
                Console.WriteLine("Вы не справились с выбором операции, он сделан за Вас");
                oper = '*';
                delOper=Multiply;
            }
            Console.WriteLine("Результат операции "+oper+" = "+delOper(x,y));
        }
    }
}