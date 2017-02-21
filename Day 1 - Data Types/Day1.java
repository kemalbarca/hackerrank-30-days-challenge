import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Day1 {
	
    public static void main(String[] args) {
        int i = 4;
        double d = 4.0;
        String s = "HackerRank ";
		
        Scanner scan = new Scanner(System.in);
		 /* Declare second integer, double, and String variables. */
        int in;
        double doub;
        String st;
        /* Read and save an integer, double, and String to your variables.*/
        // Note: If you have trouble reading the entire String, please go back and review the Tutorial closely.
        in = scan.nextInt();
        doub = scan.nextDouble();
        scan.nextLine(); //I have to add this line(It consumes the \n character)
        st = scan.nextLine();
        /* Print the sum of both integer variables on a new line. */
        System.out.println(i + in);
        /* Print the sum of the double variables on a new line. */
        System.out.println(d + doub);
        /* Concatenate and print the String variables on a new line; 
        	the 's' variable above should be printed first. */
        System.out.println(s + st);
		scan.close();
    }
}