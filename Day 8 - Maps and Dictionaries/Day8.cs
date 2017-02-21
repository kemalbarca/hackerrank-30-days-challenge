using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int input = Convert.ToInt32(Console.ReadLine());
        var map = new Dictionary<string, string>();
        for(int i=0; i<input; i++)
        {
            var nameAndPhone = Console.ReadLine();
            string key = nameAndPhone.Split(' ')[0];
            string valueTemp = nameAndPhone.Split(' ')[1];
            map.Add(key, valueTemp);
        }
        
        string line;
        while ((line = Console.ReadLine()) != null && line != "") 
        {
            string value;
            if (map.TryGetValue(line, out value))
            {
                Console.WriteLine(line + "=" + value);
            }
            else
            {
                Console.WriteLine("Not found");
            }     
        }
    }
}