using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        List<String> list = new List<String>();
        for(int a0 = 0; a0 < N; a0++){
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            string pattern = @"\b\@gmail\.\b";
            Match m = Regex.Match(emailID, pattern);
            while (m.Success) {
                list.Add(firstName);  
                //Console.WriteLine("'{0}' found at position {1}", m.Value, m.Index);
                m = m.NextMatch();
            }            
        }
        list.Sort();
        foreach(string s in list)
        {
            Console.WriteLine(s);    
        }
    }
}