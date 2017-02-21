using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Int32.Parse(Console.ReadLine());
        for(int i=0; i<n; i++){
            int angka = Int32.Parse(Console.ReadLine());
            bool flag = false;
            if(angka == 1)
            {
                Console.WriteLine("Not prime");    
            }
            else
            {
                int temp = angka/2;
                for(int j=2; j<temp; j++)
                {
                    if(angka%j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == true)
                {
                    Console.WriteLine("Not prime");    
                }
                else Console.WriteLine("Prime");
            }
        }
    }
}