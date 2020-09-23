using System;

namespace Simple_Algorithm
{
    class Program
    {
        
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }

        static void SimpleAlgorithm(int n, int[] array)
        {
            array[0] = n;

            for (int i = array.Length; i >= 1; i--)
            {
                System.Console.Write(i);
            }

        }
    

        static void Main(string[] args)
        {
            int n;
            System.Console.WriteLine("Cantidad de numeros a ordenar: ");
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];


            PrintArray(array);
            SimpleAlgorithm(n, array);
            PrintArray(array);
        }
    }
}
