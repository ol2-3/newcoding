using System;

namespace ConsoleApp8
{
    using System;

    class ArrayManipulator
    {
        public int[] GenerateRandomArray(int length, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }

        public int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

      
        public void SortArray(int[] array)
        {
            Array.Sort(array);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayManipulator manipulator = new ArrayManipulator();

            int[] array = manipulator.GenerateRandomArray(10, 1, 100);

            
            Console.WriteLine("Beginning of array:");
            PrintArray(array);

            
            int maxElement = manipulator.FindMax(array);
            Console.WriteLine($"The biggest element: {maxElement}");

           
            manipulator.SortArray(array);

           
            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

}
