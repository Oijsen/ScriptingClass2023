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
		
			// ended up needing to lookup how to convert user input into an "int" to be able to compare it against my x variable
		
		var x = 30; 
		
		var y = 10;
		
		var w = 50;
		
		var r = 80; 
		
		if (tempInput >= r) {
			Console.WriteLine("Wow! It's hot outside! Don't forget your sunscreen, and stay hydrated!");
			
		}else if(tempInput >= w){
			Console.WriteLine("It's starting to get really warm outside! Dress light and bring water!");	
		} else if(tempInput >= x){
			Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
		} else if(tempInput <= y) {
			Console.WriteLine("Brr! It's chilly outside! Grab a light jacket!");
		}else{
			Console.WriteLine("Enjoy the weather!");		
		}
		
		
	}

	
}