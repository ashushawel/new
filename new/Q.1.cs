
using System;  
namespace WordReverse {  
 public static class Extension {  
  // This method will be treated as an extension and Static based on the way of call  
  public static string[] ReverseWord(this string[] strArray) {  
   if (strArray is null) {  
    throw new ArgumentNullException(nameof(strArray));  
   }  
   string temp;  
   int j = strArray.Length - 1;  
   for (int i = 0; i < j; i++) {  
    temp = strArray[i];  
    strArray[i] = strArray[j];  
    strArray[j] = temp;  
    j--;  
   }  
   return strArray;  
  }  
 }  
 