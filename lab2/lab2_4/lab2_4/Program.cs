using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"C:\Users\Диана\Desktop\Новая папка";  // где я хочу создать 
            string s1 = "D111.txt";                                  // название файла который хочу создать 
            string s2 = Path.Combine(s, s1);                            // скомбинируем их пути 
            FileStream fs = File.Create(s2);
            fs.Close();             // создаем файл 

            string where = @"C:\Users\Диана\Desktop\Новая папка\D111.txt";  // где этот файл находится
            string where1 = @"C:\Users\Диана\Desktop\Новая папка (2)\D111.txt";     //и куда я хочу переместить 
            File.Copy(where, where1);                                // коипрую 
            File.Delete(@"C:\Users\Диана\Desktop\Новая папка\D111.txt");  // и удаляю первое место где этот файл находился

        }
    }
}
