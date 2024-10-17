using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prct1210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание1  Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива.
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

                if (sr == 1)
                {
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
            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            # region Задание 2 Создайте приложение, отображающее количество значений в массиве меньше заданного параметра пользователем. Например, количество значений меньших, чем 7 (7 введено пользователем с клавиатуры).
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-30, 30);
                Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________");
            int der = Convert.ToInt32(Console.ReadLine());
            int sr1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] < der))
                {
                    sr1++;
                }
            }
            Console.WriteLine(sr1);
            Console.WriteLine("___________________________________");
            #endregion


            # region Задание 3  Пользователь вводит с клавиатуры три числа. Необходимо подсчитать сколько раз последовательность из этих трёх чисел встречается в массиве Например пользователь ввёл: 7 6 5 массив: 7 6 5 3 4 7 6 5 8 7 6 5; количество повторений последовательности: 3.
            int[] arr3 = { 7, 5, 1, 0, 4, 7, 5, 1, 4, 7, 0, 1 };
            int[] arr5 = new int[3];
            int[] arr4 = new int[3];
            Console.WriteLine("Enter Enter numbers to search-> ");
            for (int i1 = 0; i1 < arr4.Length; i1++)
            {
                arr4[i1] = Convert.ToInt32(Console.ReadLine());
            }

            int cal1 = 0;
            int cal2 = 0;
            int k = 0;
            for (int i = 0; i < arr3.Length; i++)
            {
                if (i <= (arr3.Length - 3))
                {
                    k = i;
                    for (int j = 0; j < arr5.Length; j++)
                    {
                        arr5[j] = arr3[k];
                        k++;
                    }
                }

                for (int j1 = 0; j1 < arr4.Length; j1++)
                {
                    if (arr5[j1] == arr4[j1]) { cal1 += 1; }
                }
                if (cal1 == 3)
                {
                    cal2 += 1;
                }
                cal1 = 0;
            }
            Console.Write("number of repetitions ->"); Console.WriteLine(cal2);
            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            # region Задание 4 Даны 2 массива размерности M и N соответственно.Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
            int[] arr6 = { 7, 5, 1, 0, 4, 7, 5, 1, 4, 7, 0, 1 };
            int[] arr7 = { 7, 3, 1, 0, 1, 9, 5 };
            if (arr6.Length > arr7.Length)
            {
                int[] arr8 = new int[arr6.Length];
                for (int i = 0; i < arr6.Length; i++)
                {
                    for (int j = 0; j < arr7.Length; j++)
                    {
                        if (arr7[j] == arr6[i])
                        {
                            arr8[j] = arr6[i];
                        }
                        else if (arr7[j] != arr6[i]) { arr8[j] = 0; }
                    }

                }
                for (int i = 0; i < arr8.Length; i++)
                {
                    Console.WriteLine(arr8[i]);
                }


            }

            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            #region Задание 5 Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве.
            int[,] intArray = new int[5, 5];


            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = rnd.Next(-30, 30);
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
                    if (intArray[i, j] > max) { max = intArray[i, j]; }
                    if (intArray[i, j] < min) { min = intArray[i, j]; }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            #region Задание 6 Пользователь вводит предложение с клавиатуры.Вам необходимо подсчитать количество слов в нём.
            string str1 = Console.ReadLine();
            int l1 = str1.Length;
            char[] arr21 = str1.ToCharArray();
            Console.WriteLine("-----------------------");
            int sm = 0;
            for (int i = 0; i < l1; i++)
            {
                if (arr21[i] == ' ' || arr21[i] == '.' || arr21[i] == '!' || arr21[i] == '?')
                {
                    sm++;
                }
            }
            Console.Write("Number of words ->"); Console.WriteLine(sm);
            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            #region Задание7  Пользователь вводит предложение с клавиатуры. Вам необходимо перевернуть каждое слово предложения и отобразить результат на экран. Например:пользователь ввёл: sun cat dogs cup tea; после переворота: nus tac sgod puc aet.
            string str = Console.ReadLine();
            int l = str.Length;
            char[] arr2 = str.ToCharArray();
            char[] arr1 = str.ToCharArray();
            Console.WriteLine("-----------------------");
            for (int i = 0; i < l; i++)
            {
                for (int j = i; j < l; j++) { arr2[j] = arr1[i]; }
                if (arr1[i] == ' ' || i == (l - 1))
                {
                    Array.Reverse(arr2);
                    Console.Write(arr2);
                }
            }
            Console.WriteLine();
            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            #region Задание 8 Пользователь вводит с клавиатуры предложение.Приложение должно посчитать количество гласных букв в нём.

            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            string text = Console.ReadLine();
            byte[] bytes = win1251.GetBytes(text);
            int r5 = 0;
            int[] test = { 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121 };
            for (int i8 = 0; i8 < bytes.Length; i8++)
            {
                int f = bytes[i8];
                for (int j8 = 0; j8 < test.Length; j8++)
                {
                    if (test[j8] == f)
                    {
                        r5++;
                    }
                }
            }
            Console.Write("Number of vowels in a sentence ->"); Console.WriteLine(r5);

            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


            #region Задание 9 Реализуйте приложение для подсчёта количество вхождений подстроки в строку.Пользователь вводит исходную строку и слово для поиска. Приложений отображает результат поиска.Например:пользователь ввёл: Why she had to go.I don't know,wouldn't say;подстрока для поиска: she; результат поиска: 2
            string str9 = Console.ReadLine();
            int l9 = str9.Length;
            char[] arr9 = str.ToCharArray();

            Console.WriteLine("Entersearch word -> ");
            string str10 = Console.ReadLine();
            int l10 = str10.Length;
            char[] arr10 = str.ToCharArray();

            int[] arr11 = new int[str10.Length];


            int cal11 = 0;
            int cal21 = 0;
            int k1 = 0;
            for (int i = 0; i < arr9.Length; i++)
            {
                if (i < (arr9.Length - arr11.Length))
                {
                    k1= i;
                    for (int j = 0; j < arr10.Length; j++)
                    {
                        arr11[j] = arr9[k1];
                        k1++;
                    }
                }

                for (int j1 = 0; j1 < arr10.Length; j1++)
                {
                    if (arr10[j1] == arr11[j1]) 
                    {
                        cal11 += 1;
                    }
                }
                if (cal11 == arr10.Length)
                {
                    cal21 += 1;
                }
                cal11 = 0;
            }
            Console.Write("number of repetitions ->"); Console.WriteLine(cal21);
            Console.WriteLine("00000000000000000000000000000000000000000000000");
            #endregion


        }
    }
}
