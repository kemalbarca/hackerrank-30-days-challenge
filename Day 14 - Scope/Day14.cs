using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
	
	public Difference(int[] elm)
    {
        elements = elm;   
    }
    
    public void computeDifference()
    {
        maximumDifference = 0;
        for(int i=0; i<elements.Length; i++)
        {
            for(int j=0; j<elements.Length; j++)
            {
                int temp = Math.Abs(elements[i] - elements[j]);
                if(temp > maximumDifference)
                {
                    maximumDifference = temp;    
                }
            }
        }
    }
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}