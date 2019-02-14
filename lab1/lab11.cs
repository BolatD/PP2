using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split();         //split нужен для того чтобы разделить по частям строку 

            for (int i = 0; i < n; i++)                         //пробегаемся по форику 
            {
                a[i] = int.Parse(s[i]);                    //каждого string меняем на значение int
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0 || a[i]==1)         //проверяем каждый a[i] на j
                    {                                        //если условие выполнено, значит a[i] составное или если равен 1
                        a[i] = 0;                                //этих чисел мы приравниваем 0,это потому что простые числа 
                    }
                }
            }
            int k = 0;                                         // создаем еще один int который равно 0
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 1) k++;                           //если a[i] больше 1,то считываем количество чисел 
            }
            Console.WriteLine(k);
            for (int i = 0; i < n; i++)
            {                                                 // если a[i] не равно 0,то это простое число и мы выводим все эти числа через пробел 
                if (a[i] > 1) Console.Write(a[i] + " ");
            }
        }
    }
}
