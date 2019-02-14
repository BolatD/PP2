

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];                                   //cоздаем массив
            string[] s = Console.ReadLine().Split();         //split нужен для того чтоб разделить по частям строку 

            for (int i = 0; i < n; i++)                         //пробегаемся по форику 
            {
                a[i] = int.Parse(s[i]);                    //массиву даем значение int 
            }
              for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] +" "+a[i]+ " " );          // каждый a[i] выводим по два раза через пробел ,это и есть дубликаты 
            }

        }
    }
}
