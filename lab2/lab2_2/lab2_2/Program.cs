﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Диана\Desktop\pp2\lab2\lab2_2\input.txt"); // считываем с input.txt 
            string s = sr.ReadToEnd(); // и все записываем как строку s
            sr.Close(); // закрываем StreamReader
            StreamWriter sw = new StreamWriter(@"C:\Users\Диана\Desktop\pp2\lab2\lab2_2\output.txt"); // в конце выведим все данные на output.txt 
            string[] s1 = s.Split(); // строку s поделили и внесли это в массив
            for (int i = 0; i < s1.Length; i++) // пробегаемся по массиву
            {
                int cnt = 0; // нужно что бы посчитать сколько будет делителей у каждого числа
                int x = int.Parse(s1[i]); // переводим строку в int x
                for (int j = 1; j <= x; j++) // с этим циклом посчитаем сколько у этого числа делителей
                {
                    if (x % j == 0) // если есть делитель то cnt++
                    {
                        cnt++;
                    }
                }
                if (cnt == 2) // когда у нас 2 делителя то это число prime
                {
                    sw.Write(x + " "); //записываем его в output.txt
                }
            }
            sw.Close();//закрываем
        }

    }
}

