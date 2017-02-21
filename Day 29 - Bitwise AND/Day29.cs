using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        var n = int.Parse(Console.ReadLine());

        for (int counter = 0; counter < n; counter++)
        {
            var input = Console.ReadLine().Split(' ');
            var angka1 = int.Parse(input[0]);
            var angka2 = int.Parse(input[1]);

            int max = 0;

            for (int i = 1; i < angka1; i++)
            {
                for (int j = i + 1; j <= angka1; j++)
                {
                    int temp = i & j;
                    if (temp < angka2 && max < temp) 
                    {
                        max = temp;
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}