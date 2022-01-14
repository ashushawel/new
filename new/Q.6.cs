using System;  
using System.Collections;  
  
public class Program  
{  
    public static void Main()  
    {  
        int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };  
        Array.Sort(array); //sorting array  
        Array.Reverse(array); // Reverse Sorting array value  
        Console.WriteLine("Second Highest Value In Array " + array[1]);  
          
        foreach (var result in array)    
        {    
            Console.Write(result + " "); // Array values   
        }   
    }  
}  

 