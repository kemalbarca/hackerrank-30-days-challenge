using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int input = Convert.ToInt32(Console.ReadLine());
        Factorial f = new Factorial();
        Console.WriteLine(f.HitungFactorial(input));
    }
    
    public class Factorial {
        public int HitungFactorial(int n)
        {
            //base case
            if(n <= 1)
            {
                return n;
            }
            else
            {
                //recursive case
                return n*(HitungFactorial(n-1));
            }
        }
    }
}