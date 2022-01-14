using System;
using System.Linq;

public class Example
{
	public static void Main()
	{
		string str = "Techie Delight";
		char ch = 'e';

		int freq = str.Count(f => (f == ch));
		Console.WriteLine(freq);
	}
}
