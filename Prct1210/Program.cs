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


            # region Задание 2 Создайте приложение, отображающее количество значений в массиве меньше заданного параметра пользователем. Например, количество значений меньших, чем 7 (7 введено пользователем с клавиатуры).
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-30, 30); // от -20 до +20
                Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________");
            int der = Convert.ToInt32(Console.ReadLine());
            int sr1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if((arr[i] < der)){
                    sr1++;
                }
            }
            Console.WriteLine(sr1);

            #endregion
            # region Задание 5 Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве.
            int[,] intArray = new int[5, 5];

            Console.WriteLine("Length = {0}", intArray.Length);

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i,j] = rnd.Next(-30, 30);
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int max = intArray[0, 0];
            int min = intArray[0, 0];

            Console.WriteLine("-----------------------");
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] > max) {max= intArray[i, j];}
                    if (intArray[i, j] < min) { min = intArray[i, j]; }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            #endregion
        }
    }
}
