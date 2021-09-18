using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        //Bubblesort
        static void BubbleSortExample()
        {
            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            int numLength = number.Length;
            int temp;

            for (int i = 0; i < numLength - 1; i++)
            {
                for (int j = 0; j < numLength - 1; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        temp = number[j + 1];
                        number[j + 1] = number[j];
                        number[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending numbers: ");
            foreach (int x in number)
            {
                Console.Write(x + " ");
            }
        }
        static void Main(string[] args)
        {
            BubbleSortExample();
            Console.ReadLine();

        }
    }
}
