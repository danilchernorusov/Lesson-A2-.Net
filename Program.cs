using System;

namespace Program
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        static void BubbleSort(int[] array) 
        {
            Console.WriteLine("BubbleSort");
            int counter1 = 0;
            int counter2 = 0;
            int len = array.Length;

            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    counter1++;
                    if (array[j] > array[j + 1])
                    {
                        counter2++;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"Number of comparisons - {counter1}. The number of exchanges of elements in the array is {counter2}.");

            PrintArray(array);
        }

        static void SelectionSort(int[] array)
        {
            int counter1 = 0;
            int counter2 = 0;
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < len; j++)
                {
                    counter1++;
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                counter2++;
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            Console.WriteLine($"Number of comparisons - {counter1}. The number of exchanges of elements in the array is {counter2}.");

            PrintArray(array);
        }

        static void InsertionSort(int[] array)
        {
            int counter1 = 0;
            int counter2 = 0;
            int len = array.Length;

            for (int i = 1; i < len; i++)
            {
                int c = array[i];
                int j;
                counter1++;
                for (j = i - 1; j >= 0 && array[j] > c; j--)
                {
                    counter2++;
                    array[j + 1] = array[j];
                }
                array[j + 1] = c;
            }

            Console.WriteLine($"Number of comparisons - {counter1}. The number of exchanges of elements in the array is {counter2}.");

            PrintArray(array);
        }

        static void Main()
        {
            int[] numbers = { 1, 4, 2, 3, 9, 10, 6, 5, 8, 7, };

            Console.WriteLine("Initial array:");
            PrintArray(numbers);

            int[] numbersCopy = new int[numbers.Length];
            numbers.CopyTo(numbersCopy, 0);

            BubbleSort(numbersCopy);

            numbers.CopyTo(numbersCopy, 0);

            SelectionSort(numbersCopy);

            numbers.CopyTo(numbersCopy, 0);

            InsertionSort(numbersCopy);

            Console.WriteLine("\n");


            int[] numbers2 = { 1, 2, 3, 5, 4, 10, 6, 7, 8, 9, };

            Console.WriteLine("Initial array:");
            PrintArray(numbers2);

            numbersCopy = new int[numbers2.Length];
            numbers2.CopyTo(numbersCopy, 0);

            BubbleSort(numbersCopy);

            numbers2.CopyTo(numbersCopy, 0);

            SelectionSort(numbersCopy);

            numbers2.CopyTo(numbersCopy, 0);

            InsertionSort(numbersCopy);

            Console.WriteLine("\n");


            int[] numbers3 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Initial array:");
            PrintArray(numbers3);

            numbersCopy = new int[numbers3.Length];
            numbers3.CopyTo(numbersCopy, 0);

            BubbleSort(numbersCopy);

            numbers3.CopyTo(numbersCopy, 0);

            SelectionSort(numbersCopy);

            numbers3.CopyTo(numbersCopy, 0);

            InsertionSort(numbersCopy);
        }
    }
}