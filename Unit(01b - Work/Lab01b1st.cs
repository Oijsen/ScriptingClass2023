using System;
//Create a program that asks the user to enter the current temperature in Celsius. Use an "if" statement to check if the temperature exceeds 30 degrees Celsius. 
		 // If it is, display a message suggesting the user stay hydrated and avoid staying in the sun for too long. If the temperature is below 30 degrees Celsius, display a message suggesting the user enjoys the pleasant weather.
public class Program
{
	 public void Main() {
		
		 TempCheck();

	 }
	
	public void askUser(){

	}
	
	public void TempCheck(){
		
		int tempInput = Convert.ToInt32(Console.ReadLine());
	
		
		var x = 30; 
		
		if (tempInput > x) {
			Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
		} else {
			Console.WriteLine("Enjoy the pleasant weather.");
		}
		
	}

	
}