using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N = Convert.ToInt32(Console.ReadLine());
        string elements = Console.ReadLine();
        string[] array = elements.Split(' ');
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += Convert.ToInt32(array[i]);
        }
        Console.WriteLine(sum);

    }
}