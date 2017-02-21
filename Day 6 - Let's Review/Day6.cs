using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i=0; i<n; i++)
        {
            string word = Console.ReadLine();
            GetLetter gl = new GetLetter(word);
            char[] first;
            if(word.Length%2 == 0)
                {
                first = new char[word.Length/2];
            }
            else first = new char[(word.Length/2)+1];
            char[] second = new char[word.Length/2];
            first = gl.EvenLetter();
            second = gl.OddLetter();
            
            for(int j=0; j<first.Length; j++)
            {
                Console.Write(first[j]);    
            }
            Console.Write(" ");
            for(int j=0; j<second.Length; j++)
            {
                Console.Write(second[j]);    
            }
            Console.WriteLine("");
        }
    }
    
    public class GetLetter
    {
        char[] charArray;
        public GetLetter(string word)
        {
            charArray = word.ToCharArray();
        }
        
        public char[] EvenLetter()
        {
            char[] evenArray;
            if(charArray.Length%2 == 0)
                {
                evenArray = new char[charArray.Length/2];
            }
            else evenArray = new char[(charArray.Length/2)+1];
            int counter = 0;
            for(int i=0; i<charArray.Length; i++)
            {
                if(i==0 || i%2 == 0)
                {
                    evenArray[counter] = charArray[i];
                    counter++;
                }
            }
            return evenArray;
        }
        
        public char[] OddLetter()
        {
            char[] oddArray = new char[charArray.Length/2];
            int counter = 0;
            for(int i=1; i<charArray.Length; i++)
            {
                if(i==1 || i%2 == 1)
                {
                    oddArray[counter] = charArray[i];
                    counter++;
                }
            }
            return oddArray;
        }
    }
}