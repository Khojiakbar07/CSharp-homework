using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*task 1
           int num1, num2;

           Console.Write("Enter the First number: ");
           num1 = Convert.ToInt16(Console.ReadLine());

           Console.Write("Enter the Second number: ");
           num2 = Convert.ToInt16(Console.ReadLine());

           if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0)
           {
               Console.WriteLine(num1 * num2);
           }
           else
           {
               Console.WriteLine(num1 + num2);
           }*/
            /*task 2

            string str;
            Console.Write("Input string : ");
            str = Convert.ToString(Console.ReadLine());
            Console.Write(test(str) + "\n");


            }
            public static bool test(string str)
           {
            if (str.Length > 3) { return false; }
            if ((str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90))
                return true;
            else
                return false;
            }*/




            /*task 3


            Console.WriteLine(TwoArray(new int[] { 2, 7, 12 }));
            Console.WriteLine(TwoArray(new int[] { -5, -8, 50 }));

            bool TwoArray(int[] arr)
            {
                return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
            }*/
            /*Task 4
            Console.WriteLine(IfSortedAscending(new[] { 3, 7, 10 }));
            Console.WriteLine(IfSortedAscending(new[] { 74, 62, 99 }));

              bool IfSortedAscending(int[] arr)
            {
                return arr[0] < arr[1] && arr[1] < arr[2];
            }*/
            /*Task 5 ------------------------------------------*/
            /*task 6
            double num;

            Console.Write("Enter the First number: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > 0) {
                Console.WriteLine("number is positive");
            }else if(num < 0)
            {
                Console.WriteLine("number is negative");
            }else if(num == 0){
                Console.WriteLine("number is zero");
            }
            Console.ReadLine();*/

            /*Task 7
            int Year = 2005;
            if (checkYear(Year)) {
                Console.WriteLine("Leap Year");
            } else
            {
                Console.WriteLine("Not Leap Year ");
            }

             bool checkYear(int year)
            {
                if (Year % 400 == 0)
                    return true;
                if (Year % 100 == 0)
                    return false;
                if (Year % 4 == 0)
                    return true;
                return false;
            }*/
            /*Task 8

            Console.WriteLine(IfNumberContains3(7201432));
            Console.WriteLine(IfNumberContains3(87501));

            bool IfNumberContains3(int number) 
            {
                while (number > 0)
                {
                    if (number % 10 == 3)
                    {
                        return true;
                    }
                    number /= 10;
                }
                return false;
            }*/
            /*Task 9
              {
                  for (int x = 1; x <= 10; x++)
                  {
                     for (int y = 1; y <= 10; y++)
                      {
                          Console.Write((y == 1 ? "{0,2}" : "{0,4}"), x * y);
                      }

                     Console.WriteLine();
                  }
                  Console.ReadLine();
              }*/
            /*Task 10 ----------------------*/


            /*Task 11 
            int[] array = new int[] {  9, 5, 7, 2, 1, 8 };
            Console.WriteLine("Array is sorted: ");
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();*/
            /*Task 12 
            int[] arr ={190, 291, 145, 209, 280, 300};
            int[] arr1 = { -9, -2, -7, -8, -4 };
            Array.Sort(arr);
            Console.WriteLine("The Biggest element is: " + arr[arr.Length-1]);
            Console.WriteLine("*****************************");
            Array.Sort(arr1);
            Console.WriteLine("The Biggest element is: " + arr1[arr1.Length - 1]);*/

            /*Task 13 -----------------------*/
            /*Task 14
            Console.WriteLine(ThreeIncreasingAdjacent(new[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            Console.WriteLine(ThreeIncreasingAdjacent(new[] { 7, 3, 5, 8, 9, 3, 1, 4 }));

            bool ThreeIncreasingAdjacent(int[] array)
            {
                while
            } */

            /*Task 15 
            int a = 0;
            while (a <= 99)
            {
                Console.WriteLine("a = {0}", a);
                a += 2;
            }*/


        }
    }
}