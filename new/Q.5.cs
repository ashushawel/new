using System;

class Demo
{
    static void GetSubStrings(string str)
    {
        int j=0;
        int i=0;

        Console.WriteLine("Possible sub-strings are :");
        for (i = 1; i <= str.Length; i++)
        {
            for (j = 0; j <= str.Length - i; j++)
            {   
                Console.WriteLine(str.Substring(j, i));
            }
        }
    }
   

 