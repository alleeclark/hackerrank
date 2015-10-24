using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        long N = Convert.ToInt64(Console.ReadLine());
        string elements = Console.ReadLine();
        string[] array = elements.Split(' ');
        long sum = 0;

        for (int i = 0; i < N; i++)
        {
            sum += Convert.ToInt64(array[i]);
        }
        Console.WriteLine(sum);
    }
}
