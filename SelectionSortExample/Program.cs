using System;

namespace SelectionSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 105, 120, 10, 200, 20 };
            for (int i = 0; i < num.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[minIndex] > num[j])
                    {
                        minIndex = j;
                    }
                }
                int tmp = num[i];
                num[i] = num[minIndex];
                num[minIndex] = tmp;
            }
        }
    }
}
