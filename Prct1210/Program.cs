using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prct1210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание  Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива.
            int[] arr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 20); // от -20 до +20
                Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________");
            int r = 0;
            int rd = 0;
            int sr = 0;
            int tm = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                tm = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == tm)
                    {
                        sr++;
                    }
                }
            
                if (sr==1) {
                    if (arr[i] > 0)
                    {
                        rd++;
                    }
                    else if (arr[i] < 0)
                    {
                        r++;
                    }
                }
                sr = 0;
                 
            }
            Console.WriteLine(rd);
            Console.WriteLine(r);
            #endregion


            #region
            #endregion
        }
    }
}
