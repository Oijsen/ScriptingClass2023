using System;  
public class Lab 
{  
    public static void Main()
{
   int i,j,rows;

   Console.Write("Input number of rows : ");
   rows= Convert.ToInt32(Console.ReadLine());    //used the int converter I learned from the grade assignment
   for(i=1;i<=rows;i++)
   {
	for(j=1;j<=i;j++)
	   Console.Write("{0}",i);
	Console.Write("\n");
   }
}
}