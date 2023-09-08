using System;
					
public class Program
{
	public static void Main()
	{
	string myName = "Kaitlyn"; 
		Console.WriteLine(myName);
		int y = 5;
		double x = 3.4;
		Console.WriteLine(y);
		Console.WriteLine(x);
		double w = (x + y);
		Console.WriteLine(w);
		double r = (x - y);
		Console.WriteLine(r);
		
		int m = 18;
		
		Console.WriteLine(myName + " is " + m + " years old.");
		
		string userInput;
			Console.Write("Enter number value: ");
			userInput = Console.ReadLine();
		
		string q = (y + userInput);
		Console.WriteLine(q);
	}
}