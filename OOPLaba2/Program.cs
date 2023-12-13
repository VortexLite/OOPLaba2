using System;
using System.Text;

namespace OOPLaba2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // кодировка
            Console.OutputEncoding = Encoding.UTF8;
            int size = 0, res = 0;
            Console.Write("Введіть розмір масиву = ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] myarr = new int[size];

            // заповнення масива
            ArrFilling(ref myarr);

            // сума другого додатнього і третього елемента
            FingAndSum(ref myarr, ref res);

            // вивід інформації
            Print(ref myarr, ref res);
        }

        static void ArrFilling(ref int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                // заповнення масива числами до 20
                arr[i] = random.Next(20);
            }
        }

        static void FingAndSum(ref int[] arr, ref int res)
        {
            int temp = 0;
            if (arr.Length >= 3)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // третій елемент масиву
                    if (i == 2) res += arr[i];
                    // два додатніх
                    if (arr[i] > 0)
                    {
                        temp++;
                        if (temp == 2) res += arr[i];
                    }
                }
            }
            else
            {
                Console.WriteLine("В масиві менше трьох елементів.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }

        static void Print(ref int[] arr, ref int res)
        {
            Console.WriteLine("Масив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine($"\nСумма другого додатнього і третього елемента = {res}");
            Console.ReadLine();
        }
    }
}
