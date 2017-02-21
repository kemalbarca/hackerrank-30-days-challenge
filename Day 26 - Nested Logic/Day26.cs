using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] pinjamTemp = Console.ReadLine().Split(' ');
        DateTime pinjamDate = new DateTime(Convert.ToInt32(pinjamTemp[2]), Convert.ToInt32(pinjamTemp[1]), Convert.ToInt32(pinjamTemp[0]));
        
        string[] kembaliTemp = Console.ReadLine().Split(' ');
        DateTime kembaliDate = new DateTime(Convert.ToInt32(kembaliTemp[2]), Convert.ToInt32(kembaliTemp[1]), Convert.ToInt32(kembaliTemp[0]));
        
        int diffYear = pinjamDate.Year - kembaliDate.Year;
        int diffMonths = pinjamDate.Month - kembaliDate.Month;
        int diffDays = pinjamDate.Day - kembaliDate.Day;
        
        if ((pinjamDate - kembaliDate).Days <= 0)
            Console.WriteLine("0");
        else if (diffYear > 0)
            Console.WriteLine("10000");
        else if (diffMonths > 0)
            Console.WriteLine(diffMonths * 500);
        else
            Console.WriteLine(diffDays * 15);
    }
    
}