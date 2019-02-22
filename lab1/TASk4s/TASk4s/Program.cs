using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());     // мы переводим строку в int
            for (int i = 0; i < n; i++)               //открываем новый цикл ,пробегаемся по циклу 
            {
                for (int j = 0; j < i + 1; j++)
                {

                    Console.Write("[*]");              //и до i ставим звездочки 
                }
                Console.WriteLine(" ");                // с новой строки и опять заново 
            }
        }
    }
}
