using System;
using System.IO;
using System.Linq;

namespace Yuliya
{
    class Program
    {
        static void Show(string line)
        {
            Console.WriteLine(line);
        }
        static string Zamena(string line)
        {
            line = line.Replace(',',' ');
            line = line.Replace('.',' ');
            line = line.Replace('*',' ');
            line = line.Replace('(',' ');
            line = line.Replace(')',' ');         
            return line;
        }
        static void ReadFile(string line, Action<string> action)
        {
            action(line);
        }
        static string ReadFile(string line, Func<string,string> func)
        {
            return func(line);
        }
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("C:\\Yuliya\\Lab_8_2_text.txt");
            string text = Convert.ToString(read.ReadToEnd());
            Console.WriteLine("Первоначальная строка:");
            Action<string> action = Show;
            ReadFile(text,action);
            Console.WriteLine("Строка после замены:");
            Func<string,string> func = Zamena;
            string res = ReadFile(text, func);
            ReadFile(res,action);
        }
    }
}