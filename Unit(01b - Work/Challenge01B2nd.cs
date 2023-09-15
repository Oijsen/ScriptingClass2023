using System;
//Extend your program to prompt users to enter their exam scores as percentages. Use an "if-else" statement to check the score and provide a corresponding grade. For example, if the score is between 90 and 100, display an "A" grade message.
//If the score is between 80 and 89, display a "B" grade message, and so on. Provide appropriate feedback for various score ranges.
//4. Use appropriate variable names and include comments to explain your code and the logic behind your solutions in a beginner-friendly manner.
//5. Test your program by running it and entering different values to verify that the conditional statements work correctly.
//6. If you encounter any difficulties or errors while writing the code, refer to the provided resource or seek assistance from a teacher, parent, or older sibling.
//7. After completing your script, save the file with an appropriate name and the .cs extension.
//8. Submit your completed C# script file (.cs) as the deliverable for this lab assignment.
					
public class Program
{
	public void Main()
	{
		gradeCheck();
		subjectFavorite();
	}
	
		public void gradeCheck(){
		
		int gradeInput = Convert.ToInt32(Console.ReadLine());
	
		
		var x = 90; 
			
		var y = 80;
		
		var w = 70;
			
		var q = 60;	
			
		if (gradeInput >= x) {
			Console.WriteLine("A");
			
			//I wasn't actually sure if I could use else if more than once but decided to try it and was happy it worked. 
			
		} else if (gradeInput >= y) {
			Console.WriteLine("B");
			
		} else if (gradeInput >= w) {
			Console.WriteLine("C");
			
		} else if (gradeInput >= q){
			Console.WriteLine("D");
				
		} else {
			Console.WriteLine("F");
		}
			//I figured it made more sense to generalize the "F" as a "else" statement considering by this grading scale method anything below a 60 would be an "F"
		
	}
	
	public void subjectFavorite(){
		
		var favSubject = Console.ReadLine();
		
		switch (favSubject) 
		{
		  case "Math" :
			Console.WriteLine("Math is a great subject! Study those equations!");
			break;
		  case "Science" :
			Console.WriteLine("Have fun exploring the world around you through your own experiments!");
			break;
		  case "English" :
			Console.WriteLine("Enjoy learning all the ins and outs of writing essays and understanding literature!");
			break;
			case "Art" :
			Console.WriteLine("Learn to see the world in a new and creative way! Create something new!");
			break;
		  case "History" :
			Console.WriteLine("Learn all about the past, and about the history of the world!");
			break;
		  case "PE" :
			Console.WriteLine("Lets get active! Feel that mid day adrenaline! ");
			break;
		  case "Reading" :
			Console.WriteLine("Settle down with a good book and learn from the different authors styles!");
			break;
		}
		
		}
		
	}
	