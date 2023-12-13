using System;
using System.Linq;
using System.Text;


namespace OOPLaba2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // кодировка
            Console.OutputEncoding= Encoding.UTF8;
            int size = 0, res = 0, indexMin = 0, indexMax = 0;
            Console.Write("Введіть розмір масиву = ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] myarr = new int[size];

            // заповнення масиву
            ArrFilling(ref myarr);

            // пошук індексів мінімального і максимального + добутку їх
            FindIndexMinMax(ref myarr, ref res, ref indexMin, ref indexMax);

            // вивід інформації
            Print(ref myarr, ref res, ref indexMin, ref indexMax);
        }

        static void ArrFilling(ref int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                // заповнення масива рандомними числами до 20
                arr[i] = random.Next(20);
            }
        }

        static void FindIndexMinMax(ref int[] arr, ref int res, ref int indexMin, ref int indexMax)
        {
            if (arr.Length >= 2)
            {
                // мінімальне максимальне і добуток їх
                indexMin = Array.IndexOf(arr, arr.Min());
                indexMax = Array.IndexOf(arr, arr.Max());
                res = arr[indexMin] * arr[indexMax];
            }
            else
            {
                Console.WriteLine("В масиві менше двох елементів.");
            }
        }

        static void Print(ref int[] arr, ref int res, ref int indexMin, ref int indexMax)
        {
            Console.WriteLine("Масив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine($"\nМінімальне[{indexMin}] = {arr[indexMin]}\nМаксимальне[{indexMax}] = {arr[indexMax]}");
            Console.WriteLine($"Добуток мінімального і максимального = {res}");
            Console.ReadLine();
        }
    }
}
